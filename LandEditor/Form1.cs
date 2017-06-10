

namespace LandEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "地形データ";  //ファイルの名前の説明
            FileName = "LandData";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
