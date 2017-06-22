

namespace PowerEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "勢力データ";  //ファイルの名前の説明
            FileName = "PowerData";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
