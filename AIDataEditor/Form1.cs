namespace AIDataEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "AIデータ";  //ファイルの名前の説明
            FileName = "AIData";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
