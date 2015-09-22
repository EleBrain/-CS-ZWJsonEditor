using System;
using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class SkillResultData : EventArgs {

    public string Name { get; set; }

    public string Summary { get; set; }





    //計算式をどうするか
    //s[0] = s[0] - m[2]
    //sHP = eHP - math.min(s防御力 - m攻撃力, v0) HPが回復しないようにmath.Minする
    //s[0] = s[0] - math.min(e[2] - m[1], v0)
    //文字列にする　e0=  "e0-m0"
    // "e0=e0-m0"

    public SkillType SType { get; set; }
    public string ChangeTarget { get; set; }

    public int MaxValue { get; set; }
    public int MinValue { get; set; }

    public string CalcFormula { get; set; }


    public SkillResultData() { }
    public override string ToString() {
        return Name;
    }
}


public enum SkillType {
    Down,
    Up,
    Move,
    Make,
    Summon,
    //サモン
    //メイク
    //場所入れ替え
    //音を鳴らす
    //BGMを変える
    //セリフ表示
    //アニメ表示    
    //吹き飛ばし
    //資源回収
    //地形変化
}

