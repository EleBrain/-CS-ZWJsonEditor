using System.ComponentModel;


namespace ResourceEditor {
    public class Data {

        [Description("データの名前")]
        public string Name { get; set; }

        [Description("データの概要")]
        public string Summary { get; set; }

        [Description("データのイメージ画像のインデックス")]
        public int SpriteNumber { get; set; }

        public Data() { }
        public Data(bool b) {

            Name = "新しいデータ";
            Summary = "";
        }
    }
}
