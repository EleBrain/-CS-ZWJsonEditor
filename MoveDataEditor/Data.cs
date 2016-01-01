using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }
    public string MovePower { get; set; }
    public int[] MoveCosts { get; set; }

    public Data() { }

    public Data(string name, string movePower, int[] moveCosts) {
        Name = name;
        MovePower = movePower;
        MoveCosts = moveCosts;
    }
    public override string ToString() {
        return Name;
    }
}
