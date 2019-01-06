using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class AIThinkData {
    public string UnitTag { get; set; }
    public string SkillName { get; set; }
    public string RangeName { get; set; }
    public string[] Conditions { get; set; }
    public string Point { get; set; }
    public bool IsSelect { get; set; }

    public AIThinkData() { }

}
