using System.ComponentModel;

namespace SkillData {

    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class SkillData {

        //ID
        public string ID { get; set; }
        //名前
        public string Name { get; set; }
        //概要
        public string Summary { get; set; }
        //イメージの番号
        public int SpriteNumber { get; set; }
        //条件
        public string[] Conditions { get; set; }
        //効果
        public string[] Result { get; set; }
        //範囲
        public string Range { get; set; }
        //範囲条件
        public string[] RangeConditions { get; set; }
        //選択タイプ
        public SkillSelectType SelectType { get; set; }
        //選択タイプが移動なら移動データを参照する
        public string Move { get; set; }
        //いつ発動するか
        public TimingType Timing { get; set; }

        public SkillData() { }

        public override string ToString() {
            return ID;
        }
    }

    //使用スキル　常時　スキル使用前　使用中　使用後　ターン開始　終了　
    public enum TimingType {
        Use,
        FullTime,
        SkillBefore,
        Skilling,
        SkillAfter,
        TurnStart,
        TurnEnd,

    }
}