using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class BaseData {

    public string Name { get; set; }

    public string Summary { get; set; }

    public BaseData() { }
    public override string ToString() {
        return Name;
    }
}
