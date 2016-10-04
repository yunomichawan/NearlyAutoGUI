using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterData
{
    public string CharacterId { get { return _CharacterId; } set { _CharacterId = value; } }
    private string _CharacterId;

    [GuiData("Rank:{0}")]
    public string Rank { get; set; }

    [GuiData("Lvl:{0}")]
    public int Level { get { return _Level; } set { _Level = value; } }
    public int _Level;

    [GuiData("Name:{0}")]
    public string CharacterName { get { return _CharacterName; } set { _CharacterName = value; } }
    public string _CharacterName;

    [GuiData("Hp:{0}")]
    public int Hp { get { return _Hp; } set { _Hp = value; } }
    public int _Hp;

    [GuiData("Atk:{0}")]
    public int Attack { get { return _Attack; } set { _Attack = value; } }
    public int _Attack;

    [GuiData("Def:{0}")]
    public int Deffence { get { return _Deffence; } set { _Deffence = value; } }
    public int _Deffence;

    [GuiData("Move:{0}")]
    public int Move { get { return _Move; } set { _Move = value; } }
    public int _Move;

    public int CharacterAttribute { get { return _CharacterAttribute; } set { _CharacterAttribute = value; } }
    public int _CharacterAttribute;

    [GuiData("Attribute:{0}")]
    public string CharacterAttributeName { get { return _CharacterAttributeName; } set { _CharacterAttributeName = value; } }
    public string _CharacterAttributeName;

    [GuiData("Range:{0}")]
    public int Range { get { return _Range; } set { _Range = value; } }
    public int _Range;

    public Sprite CharacterSprite { get { return _CharacterSprite; } set { _CharacterSprite = value; } }
    public Sprite _CharacterSprite;

    public CharacterData Clone()
    {
        return (CharacterData)this.MemberwiseClone();
    }
}