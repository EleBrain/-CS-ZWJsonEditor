## 作るリスト

プレイヤー　　　　　　　　一応ok  
リソース　　　　　　　　　一応ok  
地形　　　　　　　　　　　一応ok  
フィールドデータ　　　　　一応ok  
ユニットメイクパーツ　　　一応ok  
　ユニットメイクマテリアル　一応ok  
移動タイプ　　　　　　　　一応ok   
状態　　　　　　　　　　　一応ok   
条件　　　　　　　　　　　一応ok  
スキル　　　　　　　　　　一応ok  
　効果　　　　　　　　　　一応ok  
　範囲　　　　　　　　　　一応ok  
勝敗条件　　　　　　　　　一応ok  
ユニット　　　　　　　　　一応ok  


## いらないかも




### todo

フォームと処理を別クラスに分けたい

ファイルの名前を決めたい
エラー処理を作る


#### memo


Dictionaryエディタを使うにはSystem.Designの参照が必要


LitJsonでColor構造体は保存できない  
PropertygridのColor編集は用意されている色しか選べない  
Propertygridで選択中のインデックスがわからない




Dictionary<string,int>を編集したい
    Dictionary<string,int>はint配列になる
    　Itemsプロパティを見ている?
    Stringコレクションエディタ
    string配列のように一列ずつ表示したい


    EditorはとりあえずMultilineStringEditorにする
        System.Windows.Forms.Design.StringArrayEditorと
        System.Windows.Forms.Design.StringCollectionEditorがあるけど
        internalクラスなのでアクセスできない
        MultilineStringEditorはsealedクラス
    EditorがInt配列を受け取れない

    1. 自分でUITypeEditorを継承しダイアログを用意する
    2. Dictionaryを自作クラスにする

