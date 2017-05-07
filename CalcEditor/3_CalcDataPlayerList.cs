using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataPlayerList {

    public CalcPlayerValueType ValueType { get; set; }
    public CalcDataControlPlayerList ControlerData { get; set; } = new CalcDataControlPlayerList();
    public int TargetNumber { get; set; }


}
