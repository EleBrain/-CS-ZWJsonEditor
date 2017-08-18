using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class RangeData {

    //名前
    public string Name { get; set; }

    public RangeMaterial[] Materials { get; set; }

    public RangeData() { }

    public override string ToString() {
        return Name;
    }
}
