using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Windows.Forms.Design;


class DicitonaryEditor : CollectionEditor {

    private int count = 0;

    public DicitonaryEditor(Type t) : base(typeof(string[])) { }


    //初期値を決める
    protected override object CreateInstance(Type itemType) {
        return new KeyValuePair<string, int>("新しいキー" + count++.ToString(), 1);
    }
    protected override Type CreateCollectionItemType() {
        return typeof(string);
    }

    protected override object SetItems(object editValue, object[] value) {
        Dictionary<string, int> pairList = new Dictionary<string, int>();

        if (editValue == null) {
            KeyValuePair<string, int> pair = (KeyValuePair<string, int>)CreateInstance(null);
            pairList.Add(pair.Key, pair.Value);
            return pairList;
        }

        for (int i = 0; i < value.Length; i++) {

            string s = value[i].ToString();
            s = s.Replace("{", "");
            s = s.Replace("[", "");
            s = s.Replace("]", "");
            s = s.Replace("}", "");
            string[] ss = s.Split(',');
            if (ss.Length < 2) continue;
            string dkey = ss[0];
            int dvalue;
            if (int.TryParse(ss[1], out dvalue)) {
                if (!pairList.ContainsKey(dkey)) pairList.Add(dkey, dvalue);
            }
        }
        return pairList;
    }
}
