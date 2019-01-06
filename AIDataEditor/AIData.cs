using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class AIData {

    public string Name { get; set; }
    public string Summary { get; set; }

    public AIThinkData[] ThinkDatas { get; set; }

    public AIData() { }

    public override string ToString() {
        return Name;
    }
}
