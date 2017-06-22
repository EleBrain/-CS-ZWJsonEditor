
public class Data {

    public string Name { get; set; }

    public string Summary { get; set; }

    public Data() { }

    public override string ToString() {
        return Name;
    }
}
