using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(ExpandableObjectConverter))]
class Data {

    //名前
    public string Name { get; set; }

    //イメージの番号
    public int SpriteNumber { get; set; }

    //持ち主・作成可能なプレイヤーの番号
    public int OwnerNumber { get; set; }

    //移動力
    public int MovePower { get; set; }

    //移動タイプ
    public string MoveTypeName { get; set; }

    //能力
        Editor(typeof(DicitonaryEditor), typeof(UITypeEditor)),
        TypeConverter(typeof(DictionaryConverter))]
    public Dictionary<string, int> Powers { get; set; }

    //タグ
    public string[] Tags { get; set; }

    //所持スキルの名前
    public string[] SkillName { get; set; }

    //状態異常


    public Data() { }
    public override string ToString() {
        return Name;
    }
}
