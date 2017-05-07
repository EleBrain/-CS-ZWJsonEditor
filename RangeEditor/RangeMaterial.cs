using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class RangeMaterial {

    public RangeType RType { get; set; }
    public int X { get; set; }
    public int Y { get; set; }                      

    public RangeMaterial() { }
    public RangeMaterial(RangeType rType, int x, int y) {
        RType = rType;
        X = x;
        Y = y;
    }
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