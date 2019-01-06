using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {
    public string ID { get; set; }
    public string Name { get; set; }
    //概要
    public string Summary { get; set; }
    //イメージの番号
    public int SpriteNumber { get; set; }
    //条件
    public string[] Conditions { get; set; }
    //効果
    public string[] Result { get; set; }
    //範囲
    public string Range { get; set; }
    //範囲条件
    public string[] RangeConditions { get; set; }
    //選択タイプ
    public AfterSkillTargetType TargetType { get; set; }

    public Data() { }

    public override string ToString() {
        return Name;
    }
}

public enum AfterSkillTargetType {
    Myself,　　//自分と自分
    Counter,　//自分と相手
    Point,      //自分とポイント


}
