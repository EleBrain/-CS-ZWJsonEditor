
namespace BasicEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "基本データ";  //ファイルの名前の説明
            FileName = "BasicData";           //ファイルの名前
            InitializeComponent();
        }
    }
}
