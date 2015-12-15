using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }

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


