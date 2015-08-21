using System;
using System.Collections;
using System.Collections.Generic;


public class ConditionEventArgs : EventArgs {

    public ConditionType Condition { get; set; }
    public ComparisonType Comparison { get; set; }

    public string Name { get; set; }
    public int Value { get; set; }

    public ConditionEventArgs() { }
    public ConditionEventArgs(ConditionType condi, ComparisonType comp, int val) {
        Condition = condi;
        Comparison = comp;
        Value = val;
    }
    public override string ToString() {
        return Name;
    }
}


public enum ConditionType {
    POWER,
    TAG,
    SKILL,
    STATE,
    RESOURCE,
    MOVE_TYPE,
}

public enum ComparisonType {
    EQUAL,
    NOT,
    OVER,
    AND_OVER,
    UNDER,
    AND_UNDER,
}
