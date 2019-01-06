
namespace AbilityEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "能力データ";  //ファイルの名前の説明
            FileName = "AbilityData";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
