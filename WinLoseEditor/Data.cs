using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
class Data {

    [Description("名前")]
    public string Name { get; set; }

    [Description("概要")]
    public string Summary { get; set; }

    //参照するプレイヤーのタイプ
    public PlayerType Player { get; set; }
    //チェックするタイミング
    public CheckType Check { get; set; }
    //参照方法
    public ConditionType Condition { get; set; }

    public string Tag { get; set; }

    public int X { get; set; }
    public int Y { get; set; }


    //あるタグが　あるプレイヤーに　ある数　以上なら　以下なら　　
    //マップのあるポイントにたどりついたら


    public Data() { }
    public override string ToString() {
        return Name;
    }
}

public enum PlayerType {
    Me,
    Other,
    All,
}


public enum CheckType {
    MyTurnStart,
    MyTurnEnd,
    AllTurnStart,
    AllTurnEnd,
    Skill,
}

public enum ConditionType {
    Equal,
    Not,
    Over,
    AndOver,
    Under,
    AndUnder,
    Point,
}