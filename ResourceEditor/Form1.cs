using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ResourceEditor {
    public partial class Form1 : Form {

        List<Data> Datalist;

        #region "formEvent"
        public Form1() {
            InitializeComponent();
            init();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            ListSelectChange();
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            ListAdd();
        }
        private void btnRemove_Click(object sender, EventArgs e) {
            ListRemove();
        }
        private void btnRefresh_Click(object sender, EventArgs e) {
            ListUpdate();
        }


        private void tsmiSave_Click(object sender, EventArgs e) {

            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, GetJson());
            }
        }
        private void tsmiLoad_Click(object sender, EventArgs e) {


            DialogResult result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData(System.IO.File.ReadAllText(openFileDialog1.FileName));
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e) {
            Close();
        }
        private void tsmiVersion_Click(object sender, EventArgs e) {
            AboutBox1 abox = new AboutBox1();
            abox.ShowDialog();
        }
        private void btnUp_Click(object sender, EventArgs e) {
            ListUp();
        }
        private void btnDown_Click(object sender, EventArgs e) {
            ListDown();
        }
        private void nudSpriteNumber_ValueChanged(object sender, EventArgs e) {
            if (nudSpriteNumber.Value == nudSpriteNumber.Maximum) nudSpriteNumber.Value = nudSpriteNumber.Minimum + 1;
            if (nudSpriteNumber.Value == nudSpriteNumber.Minimum) nudSpriteNumber.Value = nudSpriteNumber.Maximum - 1;
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                ListUpdate();
                e.Handled = true;
            }
        }

        #endregion

        #region "変更するところ"
        private const string FILTER = "リソースデータ";

        /// <summary>フォームの内容からデータを作る</summary>
        private Data GetEditData() {
            Data data = new Data();
            data.Name = txtName.Text;
            data.Summary = txtSummary.Text;
            data.SpriteNumber = (int)nudSpriteNumber.Value;
            return data;
        }
        /// <summary>リストボックスで選択中のデータをフォームに反映</summary>
        private void SetDataForForm() {
            int index = listBox1.SelectedIndex;

            if (index < 0) return;

            txtName.Text = Datalist[index].Name;
            txtSummary.Text = Datalist[index].Summary;
            nudSpriteNumber.Value = Datalist[index].SpriteNumber;
        }

        #endregion

        /// <summary>listのインスタンス化　ファイルダイアログのフィルター変更 </summary>
        private void init() {
            Datalist = new List<Data>();

            saveFileDialog1.Filter = FILTER + "(*.dat)|*.dat|すべてのファイル(*.*)|*.*";
            openFileDialog1.Filter = FILTER + "(*.dat)||*.dat|すべてのファイル(*.*)|*.*";
        }

        /// <summary></summary>
        private void ListSelectChange() {
            SetDataForForm();
        }

        /// <summary></summary>
        private void ListUp() {
            if (listBox1.Items.Count < 2) return;
            int index = listBox1.SelectedIndex;
            if (index == 0) return;

            object tempItem = listBox1.SelectedItem;
            listBox1.Items[index] = listBox1.Items[index - 1];
            listBox1.Items[index - 1] = tempItem;
            listBox1.SelectedIndex = index - 1;
        }
        /// <summary></summary>
        private void ListDown() {
            if (listBox1.Items.Count < 2) return;
            int index = listBox1.SelectedIndex;
            if (index == listBox1.Items.Count - 1) return;

            object tempItem = listBox1.SelectedItem;
            listBox1.Items[index] = listBox1.Items[index + 1];
            listBox1.Items[index + 1] = tempItem;

            listBox1.SelectedIndex = index + 1;
        }

        /// <summary>リストボックスに追加</summary>
        private void ListAdd() {
            Data newData = (listBox1.SelectedIndex < 0) ? new Data(true) : Datalist[listBox1.SelectedIndex];

            Datalist.Add(newData);
            listBox1.Items.Add(newData.Name);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        /// <summary>リストボックスから削除</summary>
        private void ListRemove() {
            int index = listBox1.SelectedIndex;

            if (index < 0) return;

            Datalist.RemoveAt(index);
            listBox1.Items.RemoveAt(index);
        }


        /// <summary>フォームの内容に合わせてデータリストとリストボックスを更新</summary>
        private void ListUpdate() {
            int index = listBox1.SelectedIndex;

            if (index < 0) return;

            Datalist[index] = GetEditData();
            listBox1.Items[index] = Datalist[index].Name;
        }

        /// <summary>データリストをJson文字列化</summary>
        /// <returns>DataListをJson化した文字列</returns>
        private string GetJson() {
            return LitJson.JsonMapper.ToJson(Datalist);
        }

        /// <summary>読み込んだ文字列をフォームに反映</summary>
        /// <param name="json">読み込んだ文字列</param>
        private void LoadData(string json) {
            listBox1.Items.Clear();
            Datalist = LitJson.JsonMapper.ToObject<List<Data>>(json);

            for (int i = 0; i < Datalist.Count; i++) {
                listBox1.Items.Add(Datalist[i].Name);
            }
            if (listBox1.Items.Count > 0) listBox1.SelectedIndex = 0;
        }

    }
}
