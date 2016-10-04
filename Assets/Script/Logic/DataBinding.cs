using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public class DataBinding<T>
{ 
    /// <summary>
    /// プロパティに値を設定する
    /// </summary>
    /// <param name="propertyInfo">プロパティ情報</param>
    /// <param name="obj">プロパティが宣言されているクラス</param>
    /// <param name="value">設定したい値</param>
    public static void SetPropertyValue(PropertyInfo propertyInfo, object obj, object value)
    {
        try
        {
            if (value == null) return;
            Type propertyType = propertyInfo.PropertyType;
            if (propertyType.Equals(typeof(int)))
            {
                int result;
                if (int.TryParse(value.ToString(), out result))
                {
                    propertyInfo.SetValue(obj, result, null);
                }
                else
                {
                    propertyInfo.SetValue(obj, 0, null);
                }
            }
            else if (propertyType.Equals(typeof(float)))
            {
                float result;
                if (float.TryParse(value.ToString(), out result))
                {
                    propertyInfo.SetValue(obj, result, null);
                }
                else
                {
                    propertyInfo.SetValue(obj, 0, null);
                }
            }
            else if (propertyType.Equals(typeof(double)))
            {
                double result;
                if (double.TryParse(value.ToString(), out result))
                {
                    propertyInfo.SetValue(obj, result, null);
                }
                else
                {
                    propertyInfo.SetValue(obj, 0, null);
                }
            }
            else if (propertyType.Equals(typeof(bool)))
            {
                if (value.GetType().Equals(typeof(bool)))
                {
                    propertyInfo.SetValue(obj, (bool)value, null);
                }
                else
                {
                    propertyInfo.SetValue(obj, value.ToString().Equals("1"), null);
                }
            }
            else if (propertyType.Equals(typeof(DateTime)))
            {
                DateTime dateTime;
                if (DateTime.TryParse(value.ToString(), out dateTime))
                {
                    propertyInfo.SetValue(obj, dateTime, null);
                }
            }
            else if (propertyType.Equals(typeof(List<string>)))
            {
                propertyInfo.SetValue(obj, value.ToString().Split(',').ToList(), null);
            }
            else if (propertyType.Equals(typeof(string)))
            {
                propertyInfo.SetValue(obj, value.ToString(), null);
            }
        }
        catch (NullReferenceException ex)
        {
            Debug.Log(ex.Message + propertyInfo.Name);
        }
    }

    /// <summary>
    /// 指定プロパティに値を加算(対応型：int)
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="propertyName"></param>
    /// <param name="addValue">int</param>
    public static void AddPropertyValue(T obj, string propertyName, object addValue)
    {
        Type type = typeof(T);
        PropertyInfo propertyInfo = type.GetProperty(propertyName);
        if (propertyInfo == null)
        {
            return;
        }

        int value = 0;

        if (propertyInfo.PropertyType.Equals(typeof(int)) && int.TryParse(addValue.ToString(), out value))
        {
            int baseValue = (int)propertyInfo.GetValue(obj, null);
            baseValue += value;
            SetPropertyValue(propertyInfo, obj, baseValue);
        }
    }
}
