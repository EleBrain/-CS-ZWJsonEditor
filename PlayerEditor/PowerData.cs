using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class PowerData {

    public string Name { get; set; }

    [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
    public string ColorStr { get; set; }

    public int[] KnownUnits { get; set; }

    public int[] Resources { get; set; }

    public string[] WinConditions { get; set; }
    public string[] LoseConditions { get; set; }
    public ControlType Control { get; set; }

    public PowerData() { }
    public PowerData(string name, string colorStr, int[] resources,
        int[] knownUnits, string[] winConditions, string[] loseConditions, ControlType control) {
        Name = name;
        ColorStr = colorStr;
        KnownUnits = knownUnits;
        Resources = resources;
        WinConditions = winConditions;
        LoseConditions = loseConditions;
        Control = control;
    }
    public override string ToString() {
        return Name;
    }
}

public enum ControlType {
    None,
    AI,
    NoneOrHuman,
    AIOrHuman
}
