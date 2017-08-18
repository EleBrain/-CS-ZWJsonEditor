using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class FreeMakeData {

    public string Name { get; set; }
    public string Summary { get; set; }

    public string[] Tags { get; set; }
    public FreeMakeMaterial[] Material { get; set; }

    public string[] Conditions { get; set; }
    public int[] NeedResource { get; set; }

    //自動
    public bool Auto { get; set; }
    //前提条件
    public string PreParts { get; set; }
    //表示する
    public bool Visble { get; set; }

    public FreeMakeData() { }

    public override string ToString() {
        return Name;
    }
}
