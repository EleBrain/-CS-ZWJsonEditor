using System.ComponentModel;

namespace CalcData {
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class CalcDataRootBase {
        public CalcRootType RootType { get; set; }
        public CalcDataIntListBase IntList { get; set; } = new CalcDataNumber();
    }
}