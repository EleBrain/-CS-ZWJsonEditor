using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    //名前
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
    //いつ発動するか
    public TimingType Timing { get; set; }


    public Data() { }

    public Data(string name, string summary, int sprite, string[] conditions, string[] results, string range, TimingType timing) {
        Name = name;
        Summary = summary;
        SpriteNumber = sprite;
        Conditions = conditions;
        Result = results;
        Range = range;
        Timing = timing;

    }
    public override string ToString() {
        return Name;
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