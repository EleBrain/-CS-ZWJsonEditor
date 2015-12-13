using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public partial class FreeMakeForm<T> : JsonEditorForm<T>  {

    public FreeMakeForm() {
        FileTypeName = "フリーメイクデータ";  //ファイルの名前の説明
        FileName = "FreeMake";            //ファイルの名前
        InitializeComponent();
    }


}
