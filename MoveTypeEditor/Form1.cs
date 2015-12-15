

namespace MoveTypeEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "移動タイプデータ";  //ファイルの名前の説明
            FileName = "MoveTypeData";            //ファイルの名前
            InitializeComponent();
        }
    }
}
