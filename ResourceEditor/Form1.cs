
namespace ResourceEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "資源データ";  //ファイルの名前の説明
            FileName = "ResourceData";            //ファイルの名前
            InitializeComponent();
        }
    }
}
