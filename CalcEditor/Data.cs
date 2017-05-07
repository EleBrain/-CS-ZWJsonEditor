using System.Collections.Generic;
using System.Drawing.Design;
using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {
    public string Name { get; set; }
    public int Number { get; set; }
    public CalcRootType RootType { get; set; }
    public CalcDataNumber Child1 { get; set; } = new CalcDataNumber();
    public CalcDataNumber Child2 { get; set; } = new CalcDataNumber();
    public CalcDataTogether TogeterData { get; set; } = new CalcDataTogether();

    public Data() { }

    public override string ToString() {
        return Name;
    }
}
