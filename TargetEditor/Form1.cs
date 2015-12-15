

namespace TargetEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "ターゲットデータ";  //ファイルの名前の説明
            FileName = "TargetData";            //ファイルの名前
            InitializeComponent();
        }
    }
}
