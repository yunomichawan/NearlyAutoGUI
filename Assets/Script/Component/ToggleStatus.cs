using UnityEngine;
using System.Collections;

[System.Serializable]
public class ToggleStatus
{
    /// <summary>
    /// Aを選択しているかどうか
    /// </summary>
    public bool SelectedA { get { return _SelectedA; } set { _SelectedA = value; } }
    public bool _SelectedA;

    /// <summary>
    /// Bを選択しているかどうか
    /// </summary>
    public bool SelectedB { get { return _SelectedB; } set { _SelectedB = value; } }
    public bool _SelectedB;

    /// <summary>
    /// Cを選択しているかどうか
    /// </summary>
    public bool SelectedC { get { return _SelectedC; } set { _SelectedC = value; } }
    public bool _SelectedC;

    /// <summary>
    /// Dを選択しているかどうか
    /// </summary>
    public bool SelectedD { get { return _SelectedD; } set { _SelectedD = value; } }
    public bool _SelectedD;
}
