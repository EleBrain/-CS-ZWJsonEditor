using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;

[TypeConverter(typeof(ExpandableObjectConverter))]
class Data {

    public string Name { get; set; }

    public string Summary { get; set; }

    //いつ回復するか
    public RecoveryType Recovery { get; set; }

    //ユニットの色を変えるか　画像を追加するか
    public StateEffectType Effect { get; set; }

    //右上か左上に表示するマークのインデックス コレクションのインデックスと同じでいいか
    public int SpriteNumber { get; set; }
    //色を変える
    [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
    public String Color { get; set; }


    public Data() { }
    public override string ToString() {
        return Name;
    }
}

public enum StateEffectType {
    Sprite,
    Color,

}

public enum RecoveryType {
    MyTurnEnd,
    EnemyTurnEnd,
    Infinity,
}