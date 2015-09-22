using System;
using System.Collections;
using System.Collections.Generic;

public class UnitMakeMaterialEventArgs : EventArgs {

    public UMMaterialType MaterialType { get; set; }
    public UMAddRemoveType AddType { get; set; }
    public string Name { get; set; }
    public int value { get; set; }

    public UnitMakeMaterialEventArgs() { }

    public override string ToString() {
        return Name;
    }
}


//power[index] + value
//攻撃力　+ 5
//Tag[index]追加
//SKILL[index] 追加

public enum UMMaterialType {
    POWER,
    TAG,
    SKILL,
    MOVE_TYPE,
    CONDITION,

}
public enum UMAddRemoveType {
    ADD,
    MINUS,
    EQUAL,
}