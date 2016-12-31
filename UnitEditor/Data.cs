using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }

    public int SpriteNumber { get; set; }
    public int OwnerNumber { get; set; }            
    public int[] NeedResource { get; set; }

    [TypeConverter(typeof(DictionaryConverter))]
    [Editor(typeof(DicitonaryEditor), typeof(UITypeEditor))]
    public Dictionary<string, int> Abilities { get; set; }
    public string[] Tags { get; set; }
    public string[] SkillList { get; set; }
    public string[] StateList { get; set; }


    public string[] DeleteCondition { get; set; }

    public override string ToString() {
        return Name;
    }
}
