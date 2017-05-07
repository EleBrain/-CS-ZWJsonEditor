using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string ID { get; set; }
    public string Name { get; set; }
    //画像のインデックス
    public string SpriteName { get; set; }
    //所有しているプレイヤーのインデックス
    public int OwnerNumber { get; set; }
    //召喚に必要なリソース
    public int[] NeedResource { get; set; }

    //  アビリティとその数値
    [TypeConverter(typeof(DictionaryConverter))]
    [Editor(typeof(DicitonaryEditor), typeof(UITypeEditor))]
    public Dictionary<string, int> Abilities { get; set; }

    public string[] Tags { get; set; }
    //skillの名前
    public string[] SkillList { get; set; }
    //stateの名前
    public string[] StateList { get; set; }
    //deleteの名前
    public string[] DeleteCondition { get; set; }

    public override string ToString() {
        return ID;
    }
}
