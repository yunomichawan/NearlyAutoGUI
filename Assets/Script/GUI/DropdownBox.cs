using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/// <summary>
/// ドロップダウンの派生クラス
/// </summary>
public class DropdownBox : Dropdown
{
    /// <summary>
    /// 選択アイテムリスト
    /// </summary>
    public List<DropdownItemComponent> DropdownItemList { get { return _DropdownItemList; } set { _DropdownItemList = value; } }
    public List<DropdownItemComponent> _DropdownItemList = new List<DropdownItemComponent>();

    /// <summary>
    /// 選択アイテム
    /// </summary>
    public DropdownItemComponent SelectedItem
    {
        get
        {
            try
            {
                Debug.Log("getSelectValueIndex : " + this.value + ",object : " + this.gameObject.name);
                return DropdownItemList[this.value];
            }
            catch (Exception ex)
            {
                Debug.Log("selectIndex : " + this.value + "," + ex.Message);
                return null;
            }
        }
    }

    /// <summary>
    /// 選択アイテム変更イベント
    /// </summary>
    public Action<int, Transform> OnSelectedChanged;

    /// <summary>
    /// 初期選択値
    /// </summary>
    private object DefaultSelectValue { get; set; }

    /// <summary>
    /// スタート
    /// </summary>
    protected override void Start()
    {
        this.onValueChanged.AddListener(new UnityAction<int>(this.OnValueChaged));
    }

    /// <summary>
    /// 選択アイテムを設定
    /// </summary>
    /// <param name="value"></param>
    public void SetSelectedValueIndex(object value)
    {
        bool isContains = false;
        for (int i = 0; i < DropdownItemList.Count; i++)
        {
            if (DropdownItemList[i].Value.Equals(value.ToString()))
            {
                this.SetSelectedIndex(i);
                isContains = true;
                break;
            }
        }
        // 含まれていた場合
        if (isContains)
        {
            this.DefaultSelectValue = value;
        }
    }

    /// <summary>
    /// 選択アイテム設定
    /// </summary>
    /// <param name="index"></param>
    public void SetSelectedIndex(int index)
    {
        Debug.Log("next:" + index.ToString() + ",now:" + value.ToString());
        this.value = index;
    }

    /// <summary>
    /// 選択アイテムを追加
    /// </summary>
    /// <param name="dropdownItem"></param>
    public void AddItemComponent(DropdownItemComponent dropdownItem)
    {
        if (!DropdownItemList.Contains(dropdownItem))
        {
            this.options.Add(new Dropdown.OptionData(dropdownItem.Text, dropdownItem.ItemSprite));
            DropdownItemList.Add(dropdownItem);
            if (this.DefaultSelectValue != null)
            {
                if (dropdownItem.Value.Equals(this.DefaultSelectValue))
                {
                    this.SetSelectedValueIndex(this.DefaultSelectValue);
                    this.DefaultSelectValue = null;
                }
            }
        }
    }

    /// <summary>
    /// 選択アイテムをリストで追加
    /// </summary>
    /// <param name="dropdownItemList"></param>
    public void AddItemComponents(List<DropdownItemComponent> dropdownItemList)
    {
        this.options.Clear();
        foreach (DropdownItemComponent dropdownItem in dropdownItemList)
        {
            this.AddItemComponent(dropdownItem);
        }
    }

    /// <summary>
    /// 選択アイテム変更イベント
    /// </summary>
    /// <param name="selectdIndex"></param>
    public void OnValueChaged(int selectdIndex)
    {
        Debug.Log(string.Format("{0}-{1}", value, selectdIndex));
        if (this.OnSelectedChanged != null)
        {
            this.OnSelectedChanged(selectdIndex, transform);
        }
    }
}

/// <summary>
/// 選択アイテムクラス
/// </summary>
public class DropdownItemComponent
{
    /// <summary>
    /// テキスト値
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// 画像
    /// </summary>
    public Sprite ItemSprite { get; set; }
    /// <summary>
    /// バリュー値（隠し項目）
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="text"></param>
    /// <param name="sprite"></param>
    /// <param name="value"></param>
    public DropdownItemComponent(string text, Sprite sprite, string value)
    {
        this.Text = text;
        this.ItemSprite = sprite;
        this.Value = value;
    }
}