using System.Collections.Generic;
using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
class Data {

    public string Name { get; set; }

    public string Summary { get; set; }

    //フィールドマップ　読み込む地形のインデックス
    public List<int>[] FieldMap { get; set; }

    public Data() { }
    public override string ToString() {
        return Name;
    }
}
