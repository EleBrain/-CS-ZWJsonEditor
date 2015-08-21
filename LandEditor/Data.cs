using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Data {

    [Description("名前")]
    public string Name { get; set; }

    [Description("概要")]
    public string Summary { get; set; }

    [Description("イメージ画像のインデックス")]
    public int SpriteNumber { get; set; }

    [Description("生み出す資源")]
    public int[] Resources { get; set; }

    public Data() { }
    public Data(bool b) {

        Name = "新しいデータ";
        Summary = "";
        SpriteNumber = 0;
        Resources = new int[1] { 0 };

    }
    public override string ToString() {
        return Name;
    }
}
