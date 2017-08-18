using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }
    public CalcLandValueType ValueType { get; set; }
    public CalcTogetherType TogetherType { get; set; }
    public int ResourceIndex { get; set; }
    public CalcPointType PointType { get; set; }
    public string RangeName { get; set; }

    public Data() { }

    public override string ToString() {
        return Name;
    }
}
