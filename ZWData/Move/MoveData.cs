using System.ComponentModel;

namespace MoveData {

    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class MoveData {

        public string Name { get; set; }
        public string MovePower { get; set; }
        public MoveConditionData[] MoveConditions { get; set; }

        public MoveData() { }

        public override string ToString() {
            return Name;
        }
    }
}
