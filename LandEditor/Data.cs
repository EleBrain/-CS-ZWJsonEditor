using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }

    public string Summary { get; set; }

    //イメージ画像のインデックス
    public int SpriteNumber { get; set; }

    //生み出す資源
    public int[] Prodacts { get; set; }

    public Data() { }
    public override string ToString() {
        return Name;
    }
}
