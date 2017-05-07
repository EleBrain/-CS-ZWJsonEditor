using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataControlUnitList {
    public CalcUnitValueType UnitValueType { get; set; }
    public CalcControlType ControlType { get; set; }
    public string TargetName { get; set; }
    public CalcDataUnitList ChildList { get; set; } = new CalcDataUnitList();
}
