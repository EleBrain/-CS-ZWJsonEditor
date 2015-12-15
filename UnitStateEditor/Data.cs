using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }

    public string Summary { get; set; }

    //いつ回復するか
    public RecoveryType Recovery { get; set; }

    //ユニットの画像の色を変えるか　または画像を追加するか
    public StateEffectType Effect { get; set; }

    //右上か左上に表示するマークのインデックス コレクションのインデックスと同じでいいか
    public int SpriteNumber { get; set; }
    //色を変える                           
    public string ColorStr { get; set; }


    public Data() { }
    public Data(string name, string summary, RecoveryType recovery, StateEffectType effect) {
        Name = name;
        Summary = summary;
        Recovery = recovery;
        Effect = effect;
    }
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