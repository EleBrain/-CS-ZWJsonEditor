using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }

    public string Summary { get; set; }

    [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
    public string ColorStr { get; set; }
    //Imageのパス
    public Data() { }

    public override string ToString() {
        return Name;
    }
}
