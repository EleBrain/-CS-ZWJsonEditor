using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }
    public string Summary { get; set; }
    public int SpriteNumber { get; set; }

    public Data() { }
    public Data(string name, string summary, int spriteNumber) {
        Name = name;
        Summary = summary;
        SpriteNumber = spriteNumber;
    }
    public override string ToString() {
        return Name;
    }
}
