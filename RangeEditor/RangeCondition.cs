using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class RangeCondition {

    public string ConditionName { get; set; }
    public string CostCalcName { get; set; }
    public RangeCondition() { }
    public RangeCondition(string conditionName, string costCalcName) {
        ConditionName = conditionName;
        CostCalcName = costCalcName;
    }

}
