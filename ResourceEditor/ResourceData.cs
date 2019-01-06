using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class ResourceData {

    public string Name { get; set; }
    public string Summary { get; set; }
    public string AnimeName { get; set; }

    public ResourceData() { }
    public override string ToString() {
        return Name;
    }
}
