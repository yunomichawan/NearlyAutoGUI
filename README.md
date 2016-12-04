# NearlyAutoGUI
UnityのGUIをある程度自動化するライブラリ

概要 - OverView -

・このライブラリを導入することで、クラスの追加変更に対して変更されるGUIに対して柔軟に対応することができます。

・Inspector上で1つ1つGUIオブジェクトをマッピングする必要が無くなります。

## 説明  - Description -

・クラスで実装されているプロパティとゲームオブジェクトをマッピングする必要があります。

・マッピングを行っていないプロパティは、GUIに表示されることはありません。

※注意

・テーブル操作系（テーブル作成、テーブル削除、列追加等）のSqlite文は一切サポートしておりません。

## 使い方 - Usage -

・[使い方に関する記事](http://yunomichawan.hatenablog.com/)を作成しましたのでこちらを参照してください。

#### サンプルファイル一覧

・AutiGuiSampleManager.cs	… Unity上で動作確認をするためのファイル。

・DropdownItemCreate.cs		… ドロップダウンの選択項目を作成するクラス

## ライセンス - Licence -

・[MIT](https://github.com/yunomichawan/ConvenientSqliteForUnity/blob/master/LICENSE)

## 作成者 - Author -

湯呑み茶碗 - yunomichawan - 
[開発ブログ](http://yunomichawan.hatenablog.com/)
