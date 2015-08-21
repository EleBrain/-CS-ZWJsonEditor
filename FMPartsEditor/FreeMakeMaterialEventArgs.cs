using System;
using System.Collections;
using System.Collections.Generic;

public class FreeMakeMaterialEventArgs : EventArgs {

    public FMMaterialType MaterialType { get; set; }
    public FMAddRemoveType AddType { get; set; }
    public string Name { get; set; }
    public int value { get; set; }

    public FreeMakeMaterialEventArgs() { }

    public override string ToString() {
        return Name;
    }
}


//power[index] + value
//攻撃力　+ 5
//Tag[index]追加
//SKILL[index] 追加

public enum FMMaterialType {
    POWER,
    TAG,
    SKILL,
    MOVE_TYPE,
    CONDITION,

}
public enum FMAddRemoveType {
    ADD,
    MINUS,
    EQUAL,
}