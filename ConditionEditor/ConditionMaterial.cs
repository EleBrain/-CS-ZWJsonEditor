using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class ConditionMaterial {

    public string Calc1 { get; set; }
    //参照する値
    public string Calc2 { get; set; }

    //比較方法
    public ComparisonType Comparison { get; set; }

    public ConditionMaterial() { }
    public ConditionMaterial(string calc1, string calc2, ComparisonType targetComp) {
        Calc1 = calc1;
        Calc2 = calc2;
        Comparison = targetComp;
    }
}

public enum ComparisonType {
    Equal,
    Not,
    Over,
    AndOver,
    Under,
    AndUnder,
}