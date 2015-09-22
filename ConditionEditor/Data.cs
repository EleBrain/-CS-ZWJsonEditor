using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
class Data {

    public string Name { get; set; }

    public string Summary { get; set; }

    //参照する変数のタイプ
    public ReferenceType Reference { get; set; }

    //比較方法
    public ComparisonType Comparison { get; set; }

    //参照する値
    public int Value { get; set; }

    public Data() { }
    public override string ToString() {
        return Name;
    }
}

//自分を条件か　選択したユニットの条件下　全体か　選択だとしたら何番目か

public enum ReferenceType {
    Power,
    Tag,
    Skill,
    State,
    Resource,
    MoveType,
}

public enum ComparisonType {
    Equal,
    Not,
    Over,
    AndOver,
    Under,
    AndUnder,
}
