using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }
    public CalcDataChild Child1 { get; set; }
    public CalcDataChild Child2 { get; set; }

    public Data() { }

    public override string ToString() {
        return Name;
    }
}
