using System;
using System.Collections;
using System.Collections.Generic;

public class FreeMakeMaterial {

    public FMMaterialType MaterialType { get; set; }
    public FMAddRemoveType AddType { get; set; }
    public string Name { get; set; }
    public int value { get; set; }

    public FreeMakeMaterial() { }
    public FreeMakeMaterial(FMMaterialType mt, FMAddRemoveType at, string name, int val) {
        MaterialType = mt;
        AddType = at;
        Name = name;
        value = val;
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