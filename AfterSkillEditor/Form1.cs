
namespace AfterSkillEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "アフタースキルデータ";  //ファイルの名前の説明
            FileName = "AfterSkillData";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
