using UnityEngine;
using System.Collections;

/// <summary>
/// Sample Class
/// サンプルクラス
/// </summary>
public class AutiGuiSampleManager : MonoBehaviour
{

    #region inspector property

    /// <summary>
    /// 出力コントロールの親オブジェクト
    /// </summary>
    public Transform OutputCharacterTransform;

    /// <summary>
    /// ステータス入力コントロールの親オブジェクト
    /// </summary>
    public Transform InputCharacterTransform;
    public InputControlsParent InputCharacterData { get { return this.InputCharacterTransform.GetComponent<InputControlsParent>(); } }

    /// <summary>
    /// 選択コントロールの親オブジェクト
    /// </summary>
    public Transform ToggleTransform;
    public InputControlsParent InputToggleStatus { get { return this.ToggleTransform.GetComponent<InputControlsParent>(); } }

    /// <summary>
    /// サンプル表示用キャラクターデータ
    /// </summary>
    public CharacterData SampleCharacterData;

    /// <summary>
    /// サンプル表示用選択データ
    /// </summary>
    public ToggleStatus SampleToggleStatus;

    #endregion

    #region button event

    /// <summary>
    /// UI(入力コントロール群)にキャラクターデータを表示する。
    /// 「→」ボタンのイベントです。
    /// </summary>
    public void ShowCharacterInput()
    {
        InputCharacterData.Show(SampleCharacterData);
    }

    /// <summary>
    /// UIにキャラクターデータを表示する。
    /// 「Show Output」ボタンのイベントです。
    /// </summary>
    public void ShowCharacterDataOutput()
    {
        SetComponent.SetGuiComponent(this.OutputCharacterTransform, SampleCharacterData);
    }

    /// <summary>
    /// UIに選択データを表示する。
    /// 「Show Toggle Status」ボタンのイベントです。
    /// </summary>
    public void ShowToggleStatus()
    {
        InputToggleStatus.Show(SampleToggleStatus);
    }

    /// <summary>
    /// 入力されたデータを取得
    /// 「Get Input Data」ボタンのイベントです。
    /// </summary>
    public void GetCharacterInput()
    {
        CharacterData characterData = new CharacterData();
        SetComponent.SetGuiComponentToObject<CharacterData>(this.InputCharacterTransform, characterData);
        this.SampleCharacterData = characterData;

        ToggleStatus toggleStatus = new ToggleStatus();
        SetComponent.SetGuiComponentToObject<ToggleStatus>(this.ToggleTransform, toggleStatus);
        this.SampleToggleStatus = toggleStatus;
    }

    /// <summary>
    /// 入力値を反映させる
    /// 「←」ボタンのイベントです
    /// </summary>
    public void ReflectionInputData()
    {
        CharacterData characterData = new CharacterData();
        SetComponent.SetGuiComponentToObject<CharacterData>(this.InputCharacterTransform, characterData);
        SetComponent.SetGuiComponent(this.OutputCharacterTransform, characterData);
    }

    #endregion
}
