using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataControlLandList : CalcDataControlListBase {

    public CalcLandValueType ValueType { get; set; }

    public CalcDataLandList PointData { get; set; } = new CalcDataLandList();
    public int ResourceIndex { get; set; }


}
