using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataNumberBase {
    public int Number { get; set; }
    public CalcRootType RootType { get; set; }
    public CalcDataNumber Child1 { get; set; }
    public CalcDataNumber Child2 { get; set; }
    public CalcDataTogether TogeterData { get; set; }
}
