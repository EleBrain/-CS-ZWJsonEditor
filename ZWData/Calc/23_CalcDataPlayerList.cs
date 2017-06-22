namespace CalcData {
    public class CalcDataPlayerList : CalcDataIntListBase {

        public CalcPlayerValueType ValueType { get; set; }
        public CalcControlType ControlType { get; set; }
        public int ValueTargetNumber { get; set; }
        public int ControlTargetNumber { get; set; }
        public CalcTogetherType TogetherType { get; set; }
    }
}