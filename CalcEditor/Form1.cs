﻿
namespace CalcEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "計算データ";  //ファイルの名前の説明
            FileName = "CalcData";            //ファイルの名前
            InitializeComponent();
        }
    }
}
