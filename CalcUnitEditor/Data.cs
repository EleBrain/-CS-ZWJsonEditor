using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }
    public CalcUnitValueType UnitValueType { get; set; }
    public CalcControlType ControlType { get; set; }
    public string TargetName { get; set; }
    public CalcPointType PointType { get; set; }
    public string RangeName { get; set; }
    public CalcTogetherType TogetherType { get; set; }

    public Data() { }

    public override string ToString() {
        return Name;
    }
}
