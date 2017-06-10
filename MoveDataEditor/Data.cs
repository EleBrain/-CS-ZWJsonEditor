using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }
    public string MovePower { get; set; }
    public MoveConditionData[] MoveConditions { get; set; }

    public Data() { }

    public override string ToString() {
        return Name;
    }
}
