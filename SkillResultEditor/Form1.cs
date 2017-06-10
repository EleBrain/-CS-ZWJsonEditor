
namespace SkillResultEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "スキル効果データ";  //ファイルの名前の説明
            FileName = "SkillResult";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
