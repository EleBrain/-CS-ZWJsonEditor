using System.Collections.Generic;
using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Data {

    [Description("名前")]
    public string Name { get; set; }
    [Description("概要")]
    public string Summary { get; set; }
    [Description("中身")]
    public FreeMakeMaterialEventArgs[] Material { get; set; }
    [Description("条件")]
    public List<ConditionEventArgs>[] Conditions { get; set; }
    [Description("index番目の資源が必要な数")]
    public int[] Resource { get; set; }


    public Data() { }
    public Data(bool b) {

        Name = "新しいデータ";
        Summary = "";
    }
    public Data(Data data) {

        Name = data.Name;
        Summary = data.Summary;
    }
    public override string ToString() {
        return Name;
    }
}
