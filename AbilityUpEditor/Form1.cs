
namespace AbilityUpEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "能力アップデータ";  //ファイルの名前の説明
            FileName = "AbilitypData";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
