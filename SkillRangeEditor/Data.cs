using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
class Data {

    [Description("名前")]
    public string Name { get; set; }

    [Description("概要")]
    public string Summary { get; set; }

    public RangeMaterial[] Materials { get; set; }

    public Data() { }
    public Data(string name, string summary, RangeMaterial[] materials) {
        Name = name;
        Summary = summary;
        Materials = materials;
    }
    public override string ToString() {
        return Name;
    }
}
