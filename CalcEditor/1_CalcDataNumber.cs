using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class CalcDataNumber {
    public int Number { get; set; }
    public CalcRootType RootType { get; set; }
    public CalcDataNumber Child1 { get; set; } 
    public CalcDataNumber Child2 { get; set; } 
    public CalcDataTogether TogeterData { get; set; } = new CalcDataTogether();
}
