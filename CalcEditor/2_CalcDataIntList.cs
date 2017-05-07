using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataIntList {
    public CalcListTargetType ListTargetType { get; set; }
    public CalcDataControlUnitList ControlUnitListData { get; set; } = new CalcDataControlUnitList();
    public CalcDataControlLandList ControlLandListData { get; set; } = new CalcDataControlLandList();
    public CalcDataPlayerList PlayerData { get; set; } = new CalcDataPlayerList();
}

