using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }

    public string Summary { get; set; }

    public string[] Formula { get; set; }

    public Data() { }
    public Data(string name, string summary, string[] formula) {
        Name = name;
        Summary = summary;
        Formula = formula;
    }
    public override string ToString() {
        return Name;
    }
}
