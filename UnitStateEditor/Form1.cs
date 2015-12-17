

namespace UnitStateEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "ユニット状態データ";  //ファイルの名前の説明
            FileName = "UnitStateData";            //ファイルの名前
            InitializeComponent();
            init();
        }
    }
}
