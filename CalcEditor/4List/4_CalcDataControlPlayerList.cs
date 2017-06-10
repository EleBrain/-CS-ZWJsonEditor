using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataControlPlayerList  {
    public CalcControlType ControlType { get; set; }
    public int TargetNumber { get; set; }

}
