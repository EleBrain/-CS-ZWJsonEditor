using System;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using BasicData;

namespace BasicEditor {
    public partial class Form2 : Form {
        private BasicData.BasicData Data;

        public Form2() {
            InitializeComponent();
        }

        public void ShowForm(BasicData.BasicData data) {
            Data = data;
            ShowDialog();

        }
        public void CloseForm() {
            Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            Convert();
            CloseForm();
        }
        private void Convert() {
            Rootobject v;
            try {
                v = JsonConvert.DeserializeObject<Rootobject>(textBox1.Text);
            } catch (Exception) {
                MessageBox.Show("変換に失敗しました");
                return;
            }
            if (v == null) {
                MessageBox.Show("変換に失敗しました");
                return;
            }
            if (v.layers.Count() < 2) {
                MessageBox.Show("変換に失敗しました");
                return;
            }
            Data.FieldHeight = v.height;
            Data.FieldWidth = v.width;

            Data.FieldData = new int[v.height][];
            for (int i = 0; i < v.height; i++) {
                Data.FieldData[i] = new int[v.width];
            }
            Data.UnitData = new int[v.height][];
            for (int i = 0; i < v.height; i++) {
                Data.UnitData[i] = new int[v.width];
            }

            int c = 0;
            int x = 0;
            int y = 0;
            int[] Field = v.layers.First().data;
            int[] unit = v.layers[1].data;
            int unitOffset = unit.Where(u => u > 0).Min() - 1;

            for (int i = 0; i < v.layers.First().data.Length; i++) {
                Data.FieldData[y][x] = Field[i];
                if (0 < unit[i]) Data.UnitData[y][x] = unit[i] - unitOffset;
                Data.FieldData[y][x]--;
                Data.UnitData[y][x]--;
                ++c;
                x = c % v.width;
                y = c / v.width;
            }
        }
    }
}
