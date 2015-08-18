using System.ComponentModel;

namespace JsonEditor {
    class Data {

        [Description("データの名前")]
        public string Name { get; set; }

        [Description("データの概要")]
        public string Summary { get; set; }

        public Data() { }
        public Data(bool b) {

            this.Name = "新しいデータ";
            this.Summary = "";
        }
    }
}
