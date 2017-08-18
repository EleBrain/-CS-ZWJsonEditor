
namespace CalcUnitEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "計算データユニット部";  //ファイルの名前の説明
            FileName = "CalcUnitData";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
