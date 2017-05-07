using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    //名前
    public string Name { get; set; }

    public RangeMaterial[] Materials { get; set; }
    public RangeCondition[] Conditions { get; set; }

    public Data() { }

    public override string ToString() {
        return Name;
    }
}


