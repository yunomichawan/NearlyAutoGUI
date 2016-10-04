using System;
using UnityEngine;

/// <summary>
/// 入力コントロールの親オブジェクト
/// </summary>
public class InputControlsParent : MonoBehaviour
{
    /// <summary>
    /// 親オブジェクトが管理するクラスオブジェクト
    /// </summary>
    public object BaseComponent { get; set; }

    /// <summary>
    /// オブジェクトに入力値を設定して表示する
    /// </summary>
    /// <param name="component"></param>
    public void Show(object component)
    {
        SetComponent.SetGuiComponent(gameObject.transform, component);
        this.gameObject.SetActive(true);
        this.BaseComponent = component;
    }

    /// <summary>
    /// 表示
    /// </summary>
    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    /// <summary>
    /// 入力値を引数のオブジェクトに設定する。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="baseObject"></param>
    /// <returns></returns>
    public T SetInputComponent<T>(object baseObject)
    {
        SetComponent.SetGuiComponentToObject<T>(transform, baseObject);
        return (T)baseObject;
    }
}