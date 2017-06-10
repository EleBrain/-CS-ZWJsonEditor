using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataIntList {
    public CalcListTargetType ListTargetType { get; set; }

    public CalcDataControlListBase ControlListData { get; set; }
}

