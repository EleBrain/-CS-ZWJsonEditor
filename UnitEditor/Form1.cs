
namespace UnitEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "ユニットデータ";  //ファイルの名前の説明
            FileName = "UnitData";            //ファイルの名前
            InitializeComponent();
        }
    }
}
