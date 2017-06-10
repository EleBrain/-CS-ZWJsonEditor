
namespace RangeEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "範囲データ";  //ファイルの名前の説明
            FileName = "RangeData";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
