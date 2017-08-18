using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }
    public CalcPlayerValueType ValueType { get; set; }
    public CalcControlType ControlType { get; set; }
    public int ValueTargetNumber { get; set; }
    public int ControlTargetNumber { get; set; }
    public CalcTogetherType TogetherType { get; set; }

    public Data() { }

    public override string ToString() {
        return Name;
    }
}
