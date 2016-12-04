# NearlyAutoGUI

UnityのUIにテキスト、画像をある程度自動表示、取得

===

概要 - OverView -

・このライブラリを導入することでUnityのGUI周りの表示、取得を楽に実装することができます。

## 説明  - Description -

・クラスに合わせたUnityオブジェクトを作成することでテキスト、画像の表示をサポートします。

・表示以外に、取得もサポートします。

※注意

・クラスのプロパティ名とUnityオブジェクト名がマッピングされていない場合、正常に動作しません。

・作成されたUnityオブジェクトの子オブジェクトが増えれば増えるほど、表示処理は遅くなります。

・アニメーション等は実装していません。

## 必要条件 Requirements

・特になし

## 使い方 - Usage -

・[使い方に関する記事](http://yunomichawan.hatenablog.com/entry/2016/09/27/090054)を作成しましたのでこちらを参照してください。

・このプロジェクト内にサンプルとなるソースファイルとシーンファイルが配置されています。
#### サンプルファイル一覧

・AutoGUISample.unity 		… サンプルとなる動作確認用シーンファイル。

・AutiGuiSampleManager.cs	… 動作確認用クラスファイル。

・DropdownItemCreate.cs		… 選択リスト生成クラス。

・DropdownBox.cs			… ドロップダウン(Dropdown)を継承したクラス。(インスペクター上での設定はドロップダウン(Dropdown)と同じです)

・CharacterData.cs 			… ゲームキャラクターのステータスクラス。

・ToggleStatus.cs 			… 選択値の表示、取得用サンプルクラス。

## ライセンス - Licence -

・[MIT](https://github.com/yunomichawan/ConvenientSqliteForUnity/blob/master/LICENSE)

・MITライセンスとは？という方はこちらのページを参照してください。[MITライセンスについて](http://wisdommingle.com/mit-license/)

## 作成者 - Author -

湯呑み茶碗 - yunomichawan - 
[開発ブログ](http://yunomichawan.hatenablog.com/)
