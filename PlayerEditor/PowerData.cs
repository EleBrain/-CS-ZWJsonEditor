using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class PowerData {

    public string Name { get; set; }

    [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
    public string ColorStr { get; set; }

    public ControlType ControlType { get; set; }
    public int AINumber { get; set; }

    public int[] KnownUnits { get; set; }
    public int[] Resources { get; set; }

    public string[] WinConditions { get; set; }
    public string[] LoseConditions { get; set; }


    public PowerData() { }
    public override string ToString() {
        return Name;
    }
}

public enum ControlType {
    None,
    AI,
    NoneOrAI,
    NoneOrHuman,
    AIOrHuman,
    NoneOrAIOrHuman
}
