using System;
using System.Windows.Forms;
using Newtonsoft.Json;

public partial class JsonEditorForm<T> : Form {

    private const string SettingFileName = "EditorSetting.txt";

    protected BaseDataList<T> Datalist = new BaseDataList<T>();

    protected string FileTypeName = "～データ";
    protected string FileName = "Data";


    #region "FormEvents"
    public JsonEditorForm() {
        InitializeComponent();
        init();
    }

    private void tsmiNew_Click(object sender, EventArgs e) {
        //確認する
        if (MessageBox.Show("現在のデータは破棄されます。\r\nよろしいですか？", "新規作成", MessageBoxButtons.OKCancel) == DialogResult.OK) {
            Datalist = new BaseDataList<T>();
            propertyGrid1.SelectedObject = Datalist;
            propertyGrid1.Refresh();
        }
    }
    private void tsmiSave_Click(object sender, EventArgs e) {
        //エラー処理を追加する
        //ここで上書きできるファイルがあるか判別している
        if (saveFileDialog1.FileName == "") {
            saveFileDialog1.FileName = FileName + ".dat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, GetJson());
            }
        } else {
            System.IO.File.WriteAllText(saveFileDialog1.FileName, GetJson());
        }

    }
    private void tsmiSaveAs_Click(object sender, EventArgs e) {

        saveFileDialog1.FileName = FileName + ".dat";
        if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
            System.IO.File.WriteAllText(saveFileDialog1.FileName, GetJson());
        }
    }
    private void tsmiLoad_Click(object sender, EventArgs e) {

        //エラー処理を追加する
        openFileDialog1.FileName = FileName + ".dat";
        if (openFileDialog1.ShowDialog() == DialogResult.OK) {
            LoadData(System.IO.File.ReadAllText(openFileDialog1.FileName));
        }
    }

    private void tsmiAutoSave_Click(object sender, EventArgs e) {
        tsmiAutoSave.Checked = !tsmiAutoSave.Checked;
    }

    private void tsmiExit_Click(object sender, EventArgs e) {
        Close();
    }
    private void tsmiVersion_Click(object sender, EventArgs e) {
        AboutBox1 abox = new AboutBox1();
        abox.ShowDialog();
    }

    private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
        if (e.ChangedItem.Label == "Datas") {
            propertyGrid1.ExpandAllGridItems();
        }
        propertyGrid1.Refresh();
    }
    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
        SettingDataSave();
        AutoBackUp();
    }

    #endregion

    /// <summary>listのインスタンス化　ファイルダイアログのフィルター変更 </summary>
    protected void init() {
        propertyGrid1.SelectedObject = Datalist;
        saveFileDialog1.InitialDirectory = Application.StartupPath;
        openFileDialog1.InitialDirectory = Application.StartupPath;

        saveFileDialog1.Filter = FileTypeName + "|" + FileName + ".dat|データファイル(*.dat)|*.dat|すべてのファイル(*.*)|*.*";
        openFileDialog1.Filter = FileTypeName + "|" + FileName + ".dat|データファイル(*.dat)|*.dat|すべてのファイル(*.*)|*.*";

        SettingLoad();
        DefaultLoad();
        Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

    }

    private void DefaultLoad() {
        if (System.IO.File.Exists(FileName + ".dat")) {
            LoadData(System.IO.File.ReadAllText(FileName + ".dat"));
            saveFileDialog1.FileName = FileName + ".dat";
        }
    }

    private void SettingLoad() {

        //セッティングフォームからロード
        if (System.IO.File.Exists(SettingFileName)) {
            try {
                string settingText = System.IO.File.ReadAllText(SettingFileName);
                EditorSettingData setting = JsonConvert.DeserializeObject<EditorSettingData>(settingText);
                tsmiAutoSave.Checked = setting.IsAutoSave;
            } catch (Exception) {
                throw;
            }
        }
    }

    /// <summary>データリストをJson文字列化</summary>
    /// <returns>DataListをJson化した文字列</returns>
    private string GetJson() {
        //エラー処理を追加する
        if (Datalist == null || Datalist.Datas == null) return "";
        JsonSerializerSettings setting = new JsonSerializerSettings() {
            TypeNameHandling = TypeNameHandling.All
        };
        return JsonConvert.SerializeObject(Datalist.Datas, Formatting.Indented, setting);
    }

    /// <summary>読み込んだ文字列をフォームに反映</summary>
    /// <param name="json">読み込んだ文字列</param>
    private void LoadData(string json) {
        //エラー処理を追加する
        try {
            Datalist.Datas = JsonConvert.DeserializeObject<T[]>(json);
            propertyGrid1.Refresh();
            propertyGrid1.ExpandAllGridItems();
        } catch (Exception) {
            MessageBox.Show("jsonからの変換に失敗しました。");
        }
    }


    private void AutoBackUp() {
        if (tsmiAutoSave.Checked) {
            string s = GetJson();
            if (string.IsNullOrEmpty(s)) return;
            System.IO.File.WriteAllText(FileName + "backup.dat", s);
        }
    }

    private void SettingDataSave() {
        //セッティングファイルに設定を保存
        JsonSerializerSettings setting = new JsonSerializerSettings() {
            TypeNameHandling = TypeNameHandling.All
        };
        System.IO.File.WriteAllText(SettingFileName,
            JsonConvert.SerializeObject(new EditorSettingData(tsmiAutoSave.Checked), Formatting.Indented, setting));
    }


}

