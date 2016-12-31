using System;
using System.Linq;

namespace BasicEditor {
    public partial class MainForm : Form1<Data> {
        public MainForm() {
            FileTypeName = "基本データ";  //ファイルの名前の説明
            FileName = "BasicData";           //ファイルの名前
            InitializeComponent();
            init();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form2 f2 = new Form2();
            if (Datalist.Datas == null ||
                !Datalist.Datas.Any()) {
                Datalist.Datas = new Data[] { new Data() };
            }
            f2.ShowForm(Datalist.Datas.First());
            propertyGrid1.Refresh();
        }
    }
}
