using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }

    public string Summary { get; set; }

    //参照する変数のタイプ
    public ConditionMaterial[] Materials { get; set; }

    public Data() { }
    public Data(string name, string summary, ConditionMaterial[] material) {
        Name = name;
        Summary = summary;
        Materials = material;
    }

    public override string ToString() {
        return Name;
    }
}
