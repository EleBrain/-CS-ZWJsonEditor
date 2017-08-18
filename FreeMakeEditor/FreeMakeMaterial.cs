using System.ComponentModel;
[TypeConverter(typeof(ExpandableObjectConverter))]
public class FreeMakeMaterial {

    public string Name { get; set; }
    public FMMaterialType MaterialType { get; set; }
    public FMAddRemoveType AddType { get; set; }
    public int Value { get; set; }

    public FreeMakeMaterial() { }

    public override string ToString() {
        return Name;
    }
}

public enum FMMaterialType {
    Power,
    Tag,
    Image,
    Skill,
    State,
    Condition,
}
public enum FMAddRemoveType {
    Add,
    Minus,
    Equal,
}
