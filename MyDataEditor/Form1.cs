namespace MyDataEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "マイデータ";  //ファイルの名前の説明
            FileName = "MyData";            //ファイルの名前
            InitializeComponent();
            init();
        }
    }
}
