namespace CalcData {
    public class CalcDataUnitList : CalcDataIntListBase {
        public CalcUnitValueType UnitValueType { get; set; }
        public CalcControlType ControlType { get; set; }
        public string TargetName { get; set; }
        public CalcPointType PointType { get; set; }
        public string RangeName { get; set; }
        public CalcTogetherType TogetherType { get; set; }
    }
}