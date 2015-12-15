using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class MoveData {
    public string Name { get; set; }
    public int MovePower { get; set; }
    public int[] MoveCosts { get; set; }

    public MoveData() { }

    public MoveData(string name, int movePower, int[] moveCosts) {
        Name = name;
        MovePower = movePower;
        MoveCosts = moveCosts;
    }
    public override string ToString() {
        return Name;
    }
}
