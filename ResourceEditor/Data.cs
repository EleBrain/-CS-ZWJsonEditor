using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceEditor {
    class Data {

        public string Name;
        public string Summary;
        public int SpriteNumber;

        public Data() { }
        public Data(bool b) {

            this.Name = "新しいデータ";
            this.Summary = "";
        }
    }
}
