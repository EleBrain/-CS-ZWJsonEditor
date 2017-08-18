
namespace CalcLandEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "計算データ地形部";  //ファイルの名前の説明
            FileName = "CalcLandData";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
