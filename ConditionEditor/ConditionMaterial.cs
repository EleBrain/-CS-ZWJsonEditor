using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class ConditionMaterial {

    public string Target { get; set; }

    //比較方法
    public ComparisonType TargetComparison { get; set; }
    public ComparisonType CountComparison { get; set; }

    //参照する値
    public string Calc { get; set; }

    public int NeedCount { get; set; }


    public ConditionMaterial() { }
    public ConditionMaterial(string target, ComparisonType targetComp, string calc, int needCount,ComparisonType countComp) {
        Target = target;
        TargetComparison = targetComp;
        Calc = calc;
        NeedCount = needCount;
        CountComparison = countComp;
    }
}

public enum ConditionUnitTargetType {
    Me,
    Select,
    All,
    Player,
    Team,
}
public enum ConditionValueTargetType {
    None,
    Power,
    Tag,
    Skill,
    State,
    Resource,
    MoveType,
    Owner,
    Team,
    Land,
}

public enum ComparisonType {
    Equal,
    Not,
    Over,
    AndOver,
    Under,
    AndUnder,
}
