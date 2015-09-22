using System.ComponentModel;
using System.Collections.Generic;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }

    public string Summary { get; set; }

    //イメージ画像のインデックス
    public int SpriteNumber { get; set; }

    public Data() { }
    public override string ToString() {
        return Name;
    }
}
