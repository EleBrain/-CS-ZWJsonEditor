using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }
    public string Summary { get; set; }

    public string[] Tags { get; set; }
    public FreeMakeMaterial[] Material { get; set; }

    public string[] Conditions { get; set; }
    public int[] NeedResource { get; set; }

    //自動
    public bool Auto { get; set; }
    //前提条件
    public string PreParts { get; set; }
    //表示する
    public bool Visble { get; set; }

    public Data() { }
    public Data(string name, string summary, string[] tag, FreeMakeMaterial[] material, string[] conditions, int[] needResource, bool auto, string preParts, bool visble) {
        Name = name;
        Summary = summary;
        Tags = tag;
        Material = material;
        Conditions = conditions;
        NeedResource = needResource;
        Auto = auto;
        PreParts = preParts;
        Visble = visble;
    }

    public override string ToString() {
        return Name;
    }
}
