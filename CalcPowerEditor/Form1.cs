
namespace CalcPowerEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "計算データ勢力部";  //ファイルの名前の説明
            FileName = "CalcPowerData";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
