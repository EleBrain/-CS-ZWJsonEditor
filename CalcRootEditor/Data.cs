using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }
    public CalcRootType RootType { get; set; }
    public string ChildName { get; set; }

    public Data() { }

    public override string ToString() {
        return Name;
    }
}
