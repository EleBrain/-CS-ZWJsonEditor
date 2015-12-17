

namespace SkillEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "スキルデータ";  //ファイルの名前の説明
            FileName = "SkillData";            //ファイルの名前
            InitializeComponent();
            init();
        }
    }
}
