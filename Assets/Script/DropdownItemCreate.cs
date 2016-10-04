using UnityEngine;
using System.Collections;

/// <summary>
/// ドロップダウンの項目生成クラス
/// </summary>
[RequireComponent(typeof(DropdownBox))]
public class DropdownItemCreate : MonoBehaviour
{
    public DropdownBox dropdownBox
    {
        get
        {
            if(_DropdownBox == null)
            {
                _DropdownBox = GetComponent<DropdownBox>();
            }
            return _DropdownBox;
        }
    }
    private DropdownBox _DropdownBox;

    /// <summary>
    /// ドロップダウン項目カテゴリ
    /// </summary>
    public enum DropdownCategory
    {
        /// <summary>
        /// 属性
        /// </summary>
        Attribute,
        None,
    }

    public DropdownCategory dropdownCategory = DropdownCategory.None;

    void Awake()
    {
        switch (dropdownCategory)
        {
            case DropdownCategory.Attribute:
                dropdownBox.AddItemComponent(new DropdownItemComponent("fire", null, "1"));
                dropdownBox.AddItemComponent(new DropdownItemComponent("water", null, "2"));
                dropdownBox.AddItemComponent(new DropdownItemComponent("leaf", null, "3"));
                break;
            case DropdownCategory.None:
                break;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
