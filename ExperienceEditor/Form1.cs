
namespace ExperienceEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "経験点データ";  //ファイルの名前の説明
            FileName = "ExperienceData";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
