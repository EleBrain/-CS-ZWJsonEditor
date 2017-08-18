
namespace CalcCalcEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "計算データ計算部";  //ファイルの名前の説明
            FileName = "CalcDataCalc";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
