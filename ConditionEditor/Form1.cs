

namespace ConditionEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "条件データ";  //ファイルの名前の説明
            FileName = "ConditionData";            //ファイルの名前
            InitializeComponent();
            init();
        }
    }
}
