using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }

    public string Summary { get; set; }

    public SkillType SType { get; set; }
    public string[] Conditions { get; set; }
    public string ChangeTarget { get; set; }

    public string Formura { get; set; }
    public string MaxValue { get; set; }
    public string MinValue { get; set; }

    public string Range { get; set; }

    public Data() { }
    public Data(string name, string summary, SkillType type, string[] conditions,
        string target, string formura, string maxValue, string minValue, string range) {
        Name = name;
        Summary = summary;
        SType = type;
        Conditions = conditions;
        ChangeTarget = target;
        MaxValue = maxValue;
        MinValue = minValue;
        Formura = formura;
        Range = range;
    }
    public override string ToString() {
        return Name;
    }
}


public enum SkillType {
    PowerChange,    //能力変化
    Delete,         //消滅
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
    Effect,         //特殊エフェクト

}

