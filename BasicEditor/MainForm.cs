using System;
using System.Linq;

namespace BasicEditor {
    public partial class MainForm : Form1<BasicData.BasicData> {
        public MainForm() {
            FileTypeName = "基本データ";  //ファイルの名前の説明
            FileName = "BasicData";           //ファイルの名前
            InitializeComponent();
            Init();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form2 f2 = new Form2();
            if (Datalist.Datas == null ||
                !Datalist.Datas.Any()) {
                Datalist.Datas = new BasicData.BasicData[] { new BasicData.BasicData() };
            }
            f2.ShowForm(Datalist.Datas.First());
            propertyGrid1.Refresh();
        }
    }
}
