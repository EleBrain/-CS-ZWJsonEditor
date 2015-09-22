using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
class Data {

    //名前
    public string Name { get; set; }

    //概要
    public string Summary { get; set; }

    //イメージの番号
    public int SpriteNumber { get; set; }

    //条件
    public string[] Conditions { get; set; }

    //効果
    public SkillResultData[] Result { get; set; }

    //範囲
    public RangeData[] Ranges { get; set; }

    //いつ発動するか
    //スキル使用前　使用中　使用後　ターン開始　終了　常時　


    public Data() { }

    public override string ToString() {
        return Name;
    }
}
