using System;
using System.ComponentModel.Design;



//int配列を使う場合ためのサンプル
class IntsArrayEditor : CollectionEditor {

    public IntsArrayEditor(Type t) : base(t) { }

    //初期値を決める
    protected override object CreateInstance(Type itemType) {
        return new int[1];
    }

    //右上の表示がint[]プロパティになってしまうのでintに修正する
    protected override Type CreateCollectionItemType() {
        return typeof(int[]);
    }

    //そのままだとobject配列になってしまうので変換する
    protected override object SetItems(object editValue, object[] value) {
        int[][] ia;
        ia = new int[value.Length][];
        value.CopyTo(ia, 0);
        return ia;
    }
}
