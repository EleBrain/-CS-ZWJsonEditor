

namespace PlayerEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "プレイヤーデータ";  //ファイルの名前の説明
            FileName = "PlayerData";            //ファイルの名前
            InitializeComponent();
        }
    }
}
