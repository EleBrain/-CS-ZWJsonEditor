using System.ComponentModel;

namespace JsonEditor {
    class Data {

        [Description("データの名前")]
        public string Name { get; set; }

        [Description("データの概要")]
        public string Summary { get; set; }

        public Data() { }
        public Data(bool b) {

            Name = "新しいデータ";
            Summary = "";
        }
        public Data(Data data) {

            Name = data.Name;
            Summary = data.Summary;
        }
        public override string ToString() {
            return Name;
        }
    }
}
