# SetCharacterTimelineTrack

## 概要
UnityのTimelineで任意のSpriteを操作するカスタムトラックです。

Unityのノベルゲーム向けのカスタムトラックのライブラリを制作予定です。本プロジェクトは「[にじさんじ格闘ゲーム制作プロジェクト](https://x.com/nijikakuproject)」向けに制作したトラックをノベルゲーム向けに公開しています。ノベルゲームライブラリとして複数トラックをまとめて別途公開予定です。

## 特徴
- 任意のRowImagのPosition、Scaleをクリップｄ制御可能
- キャラ、背景関係なくSpriteなら制御可能
- 同時に表示するSpriteの数は無制限（ハードウェアのリソースに依存する）
- 差分切り替えが容易である。

## 実装例
[![](https://img.youtube.com/vi/qewiuaeSpf0/0.jpg)](https://www.youtube.com/watch?v=qewiuaeSpf0)


## セットアップ
### 要件
- RowImageがインストールされている。

### インストール
1. [Releases](https://github.com/hiragiyayoi/SetCharacterTimelineTrack/releases)より最新のUnityPackagesをダウンロードする．
2. Asset > Import Pakages > Custom Pakege より1のパッケージをインポートする．
4. UnityEditorを再起動する．
5. AssetフォルダにSetCharacterTrackフォルダが生成されていることを確認する．


## 使い方
Menu.Runtime.TalkingTrack > Set Character Track が該当のトラックです。

![image](https://github.com/hiragiyayoi/SetCharacterTimelineTrack/assets/84854644/0ae4a1a4-8e6a-42b0-a795-342ee969dfc5)

また、canvasオブジェクト以下に配置されたRowImageコンポーネントを含んでいるGameObjectを選択する。

![image](https://github.com/hiragiyayoi/SetCharacterTimelineTrack/assets/84854644/7956c253-45df-45b7-8513-b43ca1e0704e)

![image](https://github.com/hiragiyayoi/SetCharacterTimelineTrack/assets/84854644/bf02c9d9-e3bf-4e08-ada8-576d35af1d37)

### トラックについて
左右それぞれで異なるRowImageを用意することを想定しています。
TrackのInspectorには以下の変数が存在します。

![image](https://github.com/hiragiyayoi/SetCharacterTimelineTrack/assets/84854644/482c0c83-5e48-43e3-8009-015c301c11bb)

- Clip Out Delete Image：クリップが存在しないフレームを再生するときに１つ前のクリップで指定したスプライトを削除するか選択する。選択することでクリップ外ではスプライト表示しなくなる。


### クリップについて
ClipのInspectorには以下の変数が存在します。

![image](https://github.com/hiragiyayoi/SetCharacterTimelineTrack/assets/84854644/29d042f4-bbc2-46a9-8350-a47379d7b373)

- Character Texture：任意のスプライトを選択する。
例：3の場合、3フレームに１回最大表示文字数が増加する。
- Positon：スプライトのTransformのPositionを変更する。
- Scale：スプライトのTransformのScaleを変更する。

## 注意点
- スプライト以外の画像は対応していない
- 同一のGameObjectを指定したトラック同士では、同じタイミングでクリップを再生できない。
