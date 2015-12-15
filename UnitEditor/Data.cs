using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string Name { get; set; }

    public int SpriteNumber { get; set; }
    public int OwnerNumber { get; set; }
    //public MoveData MoveData { get; set; } = new MoveData();

    [TypeConverter(typeof(DictionaryConverter))]
    [Editor(typeof(DicitonaryEditor), typeof(UITypeEditor))]
    public Dictionary<string, int> Powers { get; set; }

    public string[] Tags { get; set; }
    public string[] SkillList { get; set; }
    public string[] StateList { get; set; }

    public string[] DeleteCondition { get; set; }

    public override string ToString() {
        return Name;
    }
}
