using System;
using System.ComponentModel;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class RangeData : EventArgs {

    public RangeType RType { get; set; }
    public int X { get; set; }
    public int Y { get; set; }


    public RangeData() { }
    //public override string ToString() {
    //    return Name;
    //}
}



public enum RangeType {
    Single,



}