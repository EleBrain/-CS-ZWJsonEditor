using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class BaseData {

    public string Name { get; set; }

    public string Summary { get; set; }

    public BaseData() { }

    public override string ToString() {
        return Name;
    }
}
