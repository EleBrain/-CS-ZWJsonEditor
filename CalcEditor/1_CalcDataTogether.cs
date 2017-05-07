using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataTogether {
    public CalcTogetherType TogetherType { get; set; }
    public CalcDataIntList IntListData { get; set; } = new CalcDataIntList();

}
