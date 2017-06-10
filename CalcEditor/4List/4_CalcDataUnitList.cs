using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataUnitList {
    public CalcPointType ValueType { get; set; }
    public string RangeName { get; set; }
}
