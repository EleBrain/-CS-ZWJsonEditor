using System.ComponentModel;

[TypeConverter(typeof(SerializableExpandableObjectConverter))]
public class UnitState {
    
    public string Name { get; set; }

    public string Summary { get; set; }

    public string AnimeName { get; set; }
    //色を変える                           
    public string ColorName { get; set; }
    //UnitStateに効果を追加する
    public string[] OrderEndResult { get; set; }
    public string[] OrderStartResult { get; set; }

    public UnitState() { }
    public override string ToString() {
        return Name;
    }

}
