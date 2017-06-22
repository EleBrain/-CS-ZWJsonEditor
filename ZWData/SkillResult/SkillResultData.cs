using System.ComponentModel;

namespace SkillResultData {

    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class SkillResultData {

        //名前
        public string Name { get; set; }
        //概要
        public string Summary { get; set; }
        //スキルの効果のタイプ
        public SkillType SType { get; set; }
        //consditionの名前 そのスキル効果を発動する条件
        public string[] Conditions { get; set; }
        //移動の場合は参照する移動力の名前
        public string Target { get; set; }
        //の計算式の名前             calc name
        public string Formura { get; set; }
        //最大値の計算式の名前    calc name
        public string MaxValue { get; set; }
        //最小値の計算式の名前    calc   name
        public string MinValue { get; set; }
        //効果の範囲 range name
        public string Range { get; set; }

        public SkillResultData() { }
        public SkillResultData(string name, string summary, SkillType type, string[] conditions,
            string target, string formura, string maxValue, string minValue, string range) {
            Name = name;
            Summary = summary;
            SType = type;
            Conditions = conditions;
            Target = target;
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
}
