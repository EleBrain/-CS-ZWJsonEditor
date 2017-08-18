
namespace CalcChildEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "～データ";  //ファイルの名前の説明
            FileName = "Data";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
