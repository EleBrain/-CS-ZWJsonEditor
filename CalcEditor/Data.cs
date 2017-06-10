using System.Collections.Generic;
using System.Drawing.Design;
using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data : CalcDataNumberBase {
    public string Name { get; set; }

    public Data() { }

    public override string ToString() {
        return Name;
    }
}
