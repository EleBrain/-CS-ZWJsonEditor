using System.ComponentModel;
using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Data {

    [Description("名前")]
    public string Name { get; set; }

    [Description("概要")]
    public string Summary { get; set; }

    [Description("イメージ画像のインデックス")]
    public int SpriteNumber { get; set; }

    [Description("名前")]
    public string[] names { get; set; }

    public Data() { }
    public Data(bool b) {

        Name = "新しいデータ";
        Summary = "";
    }
    public override string ToString() {
        return Name;
    }
}
