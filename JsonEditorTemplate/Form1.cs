﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonEditorTemplate {
    public partial class Form1<T> : JsonEditorForm<T>  {
        public Form1() {
            FileTypeName = "～ファイル";  //ファイルの名前の説明
            FileName = "data";            //ファイルの名前
            InitializeComponent();
        }
    }
}
