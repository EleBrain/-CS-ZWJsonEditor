﻿
namespace CalcPlayerEditor {
    public partial class Form1<T> : JsonEditorForm<T> {
        public Form1() {
            FileTypeName = "計算勢力データ";  //ファイルの名前の説明
            FileName = "Data";            //ファイルの名前
            InitializeComponent();
            Init();
        }
    }
}
