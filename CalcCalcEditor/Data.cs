using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }
    public CalcDataChild Child1 { get; set; } = new CalcDataChild();
    public CalcDataChild Child2 { get; set; } = new CalcDataChild();

    public Data() { }

    public override string ToString() {
        return Name;
    }
}
