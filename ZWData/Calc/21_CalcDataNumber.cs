using System.ComponentModel;

namespace CalcData {
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class CalcDataNumber : CalcDataIntListBase {
        public int Number { get; set; }
    }
}