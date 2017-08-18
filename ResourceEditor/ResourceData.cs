using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class ResourceData {

    public string Name { get; set; }
    public string Summary { get; set; }
    public int SpriteNumber { get; set; }

    public ResourceData() { }
    public ResourceData(string name, string summary, int spriteNumber) {
        Name = name;
        Summary = summary;
        SpriteNumber = spriteNumber;
    }
    public override string ToString() {
        return Name;
    }
}
