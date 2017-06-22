using System.ComponentModel;
namespace CalcData {
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class CalcDataChild : CalcDataRootBase {

    }
}