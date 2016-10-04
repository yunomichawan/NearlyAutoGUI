using System;
using UnityEngine;

/// <summary>
/// GUI表示内容形成属性
/// </summary>
public class GuiDataAttribute : Attribute
{
    /// <summary>
    /// 表示するフォ－マット
    /// </summary>
    public string DispFormat { get; set; }
    
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="format"></param>
    public GuiDataAttribute(string format)
    {
        DispFormat = format;
    }
}
