using System.ComponentModel;

namespace ConditionData {
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class ConditionData {

        public string Name { get; set; }

        public string Summary { get; set; }

        //参照する変数のタイプ
        public ConditionMaterial[] Materials { get; set; }

        public ConditionData() { }
        public ConditionData(string name, string summary, ConditionMaterial[] material) {
            Name = name;
            Summary = summary;
            Materials = material;
        }

        public override string ToString() {
            return Name;
        }
    }
}
