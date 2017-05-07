using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    //ID
    public string ID { get; set; }
    //名前
    public string Name { get; set; }
    //概要
    public string Summary { get; set; }
    //イメージの番号
    public int SpriteNumber { get; set; }
    //条件   ConditionのName
    public string[] Conditions { get; set; }
    //効果   ResultのName
    public string[] Result { get; set; }
    //範囲  RangeのName
    public string Range { get; set; }
    //いつ発動するか
    public TimingType Timing { get; set; }


    public Data() { }

    public Data(string iD, string name, string summary, int spriteNumber, string[] conditions, string[] result, string range, TimingType timing) {
        ID = iD;
        Name = name;
        Summary = summary;
        SpriteNumber = spriteNumber;
        Conditions = conditions;
        Result = result;
        Range = range;
        Timing = timing;
    }

    public override string ToString() {
        return ID;
    }
}

//使用スキル　常時　スキル使用前　使用中　使用後　ターン開始　終了　
public enum TimingType {
    Use,
    FullTime,
    SkillBefore,
    Skilling,
    SkillAfter,
    TurnStart,
    TurnEnd,

}