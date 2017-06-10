using System.ComponentModel;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Design;
using System.ComponentModel.Design;

[TypeConverter(typeof(ExpandableObjectConverter))]
class Data {

    [Description("名前")]
    public string Name { get; set; }

    [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
    public string ColorStr { get; set; }

    public int[] KnownUnits { get; set; }

    [Editor(typeof(IntsEditor), typeof(UITypeEditor))]
    public int[] Resources { get; set; }

    public string[] WinConditions { get; set; }
    public string[] LoseConditions { get; set; }

    public Data() { }
    public override string ToString() {
        return Name;
    }
}
