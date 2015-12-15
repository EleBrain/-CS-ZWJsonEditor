

public partial class FreeMakeForm<T> : JsonEditorForm<T>  {

    public FreeMakeForm() {
        FileTypeName = "フリーメイクデータ";  //ファイルの名前の説明
        FileName = "FreeMakeData";            //ファイルの名前
        InitializeComponent();
    }
}                                                                