namespace CalcData {
    public class CalcDataLandList : CalcDataIntListBase {

        public CalcLandValueType ValueType { get; set; }
        public CalcTogetherType TogetherType { get; set; }
        public int ResourceIndex { get; set; }
        public CalcPointType PointType { get; set; }
        public string RangeName { get; set; }
    }
}