using System;
using System.Collections;
using System.Collections.Generic;

public class FreeMakeMaterial {

    public string Name { get; set; }
    public FMMaterialType MaterialType { get; set; }
    public FMAddRemoveType AddType { get; set; }
    public int value { get; set; }

    public FreeMakeMaterial() { }
    public FreeMakeMaterial(string name, FMMaterialType mt, FMAddRemoveType at, int val) {
        MaterialType = mt;
        AddType = at;
        Name = name;
        value = val;
    }
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
    MoveType,
    Condition,
}
public enum FMAddRemoveType {
    Add,
    Minus,
    Equal,
}