using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataControlPlayerList {
    public int TargetNumber { get; set; }
    public CalcControlType ControlType { get; set; }

}
