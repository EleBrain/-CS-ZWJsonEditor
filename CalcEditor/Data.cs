using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
class Data {

    [Description("名前")]
    public string Name { get; set; }

    [Description("概要")]
    public string Summary { get; set; }

    public string[] Formula { get; set; }

    public Data() { }
    public override string ToString() {
        return Name;
    }
}
