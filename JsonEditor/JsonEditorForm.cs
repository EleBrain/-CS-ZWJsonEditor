using System;
using System.Windows.Forms;
using Newtonsoft.Json;

public partial class JsonEditorForm<T> : Form {


    #region "FormEvents"
    public JsonEditorForm() {
        InitializeComponent();
        init();
    }

    private void tsmiSave_Click(object sender, EventArgs e) {
        //エラー処理を追加する
        DialogResult result = saveFileDialog1.ShowDialog();
        if (result == System.Windows.Forms.DialogResult.OK) {
            System.IO.File.WriteAllText(saveFileDialog1.FileName, GetJson());
        }
    }
    private void tsmiLoad_Click(object sender, EventArgs e) {

        //エラー処理を追加する
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

    private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
        if (e.ChangedItem.Label == "Datas") {
            propertyGrid1.ExpandAllGridItems();
        }
        propertyGrid1.Refresh();
    }
    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
        string s = GetJson();
        if (string.IsNullOrEmpty(s)) return;
        System.IO.File.WriteAllText(FileName + "backup.dat", s);
    }

    #endregion

    private BaseDataList<T> Datalist = new BaseDataList<T>();
    protected string FileTypeName = "～データ";
    protected string FileName = "Data";

    /// <summary>listのインスタンス化　ファイルダイアログのフィルター変更 </summary>
    protected void init() {
        propertyGrid1.SelectedObject = Datalist;
        saveFileDialog1.InitialDirectory = Application.StartupPath;
        openFileDialog1.InitialDirectory = Application.StartupPath;

        saveFileDialog1.FileName = FileName + ".dat";
        openFileDialog1.FileName = FileName + ".dat";
        saveFileDialog1.Filter = FileTypeName + "|" + FileName + ".dat|データファイル(*.dat)|*.dat" + ".dat|すべてのファイル(*.*)|*.*";
        openFileDialog1.Filter = FileTypeName + "|" + FileName + ".dat|データファイル(*.dat)|*.dat" + ".dat|すべてのファイル(*.*)|*.*";
    }

    /// <summary>データリストをJson文字列化</summary>
    /// <returns>DataListをJson化した文字列</returns>
    private string GetJson() {
        //エラー処理を追加する
        if (Datalist == null || Datalist.Datas == null) return "";
        JsonSerializerSettings setting = new JsonSerializerSettings();
        setting.TypeNameHandling = TypeNameHandling.All;

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
        }
        catch (Exception) {
            throw;
        }
    }

}

