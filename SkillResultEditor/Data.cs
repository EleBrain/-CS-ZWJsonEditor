using System;
using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Data : EventArgs {

    public string Name { get; set; }

    public string Summary { get; set; }

    public SkillType SType { get; set; }
    public string[] Condition { get; set; }
    public string ChangeTarget { get; set; }

    public string MaxValue { get; set; }
    public string MinValue { get; set; }

    public string CalcFormula { get; set; }


    public Data() { }
    public override string ToString() {
        return Name;
    }
}


public enum SkillType {
    PowerChange,    //能力変化
    Move,           //移動
    Make,           //メイク
    Summon,         //サモン
    PointChange,    //場所入れ替え
    Se,             //音を鳴らす
    BGM,            //BGMを変える
    Serif,          //セリフ表示
    Anime,          //アニメ表示    
    Blow,           //吹き飛ばし 
    ResourceGet,    //資源回収
    LandChange,     //地形変化
    //視界

}

