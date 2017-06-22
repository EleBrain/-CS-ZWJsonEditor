using System.ComponentModel;

namespace CalcData {
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class CalcDataCalc : CalcDataIntListBase {
        public CalcDataChild Child1 { get; set; } = new CalcDataChild();
        public CalcDataChild Child2 { get; set; } = new CalcDataChild();
    }
}