using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataLandList {
    public CalcPointType PointType { get; set; }
    public string RangeName { get; set; }

}
