public enum CalcRootType {
    Number,
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Remainder,
    Random,
    Unit,
    Land,
    Power,
}

public enum CalcTogetherType {
    Total,
    Max,
    Min,
    Average,
    Count
}


public enum CalcControlType {
    All,
    MyControl,
    NotMine,
    PlayerNumber,
    TeamNumber,
    NotTeam,
}
public enum CalcPointType {
    All,
    Myposition,
    SelectPosition,
}


public enum CalcUnitValueType {
    Ability,
    Tag,
    Skill,
    State,
    Land,
    Count,
    X,
    Y,
    DistanceX,
    DistanceY,
    Manhattan,    //◆
    Chebyshev,     //■
}
public enum CalcLandValueType {
    Count,
    Resource,
    skill,
    Tag,
    X,
    Y,
    DistanceX,
    DistanceY,
    Manhattan,    //◆
    Chebyshev,     //■
}

public enum CalcPlayerValueType {
    Count,
    Resource,
    UnitCount,
    HaveUnits,
    KnownUnits,
    CanMakeUnits,
    //Tag
}


public enum ComparisonType {
    Equal,
    Not,
    Over,
    AndOver,
    Under,
    AndUnder,
}
