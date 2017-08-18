using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class RangeMaterial {

    public RangeType RType { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public string RangeCondition;

    public RangeMaterial() { }
}

public enum RangeType {
    Single,
    Line,         //|
    Cross,        //＋
    Saltire,      //Ⅹ
    Manhattan,    //◆
    Daia,         //◇
    Chebyshev,     //■
    All
}
