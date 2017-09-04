using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataChild {
    public CalcRootType RootType { get; set; }
    public string ChildName { get; set; }

}
