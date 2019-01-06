using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class Data {

    public string AbilityName { get; set; }

    public ExperienceData[] Experiences { get; set; }

    public Data() { }

    public override string ToString() {
        return AbilityName;
    }
}
