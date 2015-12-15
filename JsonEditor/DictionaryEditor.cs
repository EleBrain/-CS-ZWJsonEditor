using System;
using System.ComponentModel.Design;
using System.Collections.Generic;

//class StringsEditor : CollectionEditor {
//    public StringsEditor(Type t) : base(typeof(string[])) {    }
//    protected override Type CreateCollectionItemType() {

//        return typeof(string);
//    }
//}

//これだと<string, int>しか使えない

public class DicitonaryEditor : CollectionEditor {

    private int count = 0;
    Type k;
    Type v;
    public DicitonaryEditor(Type t) : base(typeof(string[])) {

        k = t.GetGenericArguments()[0];
        v = t.GetGenericArguments()[1];
    }


    //初期値を決める
    protected override object CreateInstance(Type itemType) {
        object key = "";
        object value = "";
        if (k == typeof(string)) {
            key = "新しいキー" + count++.ToString();
        } else if (k == typeof(int)) {
            key = count++;
        }
        if (v == typeof(string)) {
            value = "Value";
        } else if (v == typeof(int)) {
            value = 1;
        }
        return new KeyValuePair<object, object>(key, value);
    }
    protected override Type CreateCollectionItemType() {
        return typeof(string);
    }

    protected override object SetItems(object editValue, object[] value) {

        if (editValue == null) {
            Dictionary<object, object> tmpDictionary = new Dictionary<object, object>();
            KeyValuePair<object, object> tmpPair = (KeyValuePair<object, object>)CreateInstance(typeof(string));
            tmpDictionary[tmpPair.Key] = tmpPair.Value;
            return tmpDictionary;
        }


        //Activator.CreateInstance     

        if (k == typeof(string) && v == typeof(string)) {
            return GetStringString(value);
        } else if (k == typeof(string) && v == typeof(int)) {
            return GetStringInt(value);
        } else if (k == typeof(int) && v == typeof(string)) {
            return GetIntString(value);
        } else if (k == typeof(int) && v == typeof(int)) {
            return GetIntInt(value);
        }

        return null;
    }

    private static object GetStringString(object[] value) {

        Dictionary<string, string> pairList = new Dictionary<string, string>();
        for (int i = 0; i < value.Length; i++) {

            string s = value[i].ToString();
            s = s.Replace("{", "");
            s = s.Replace("[", "");
            s = s.Replace("]", "");
            s = s.Replace("}", "");
            string[] ss = s.Split(new string[] { ", " }, StringSplitOptions.None);
            if (ss.Length < 2) continue;
            pairList[ss[0]] = ss[1];
        }
        return pairList;
    }
    private static object GetStringInt(object[] value) {

        Dictionary<string, int> pairList = new Dictionary<string, int>();
        for (int i = 0; i < value.Length; i++) {

            string s = value[i].ToString();
            s = s.Replace("{", "");
            s = s.Replace("[", "");
            s = s.Replace("]", "");
            s = s.Replace("}", "");
            string[] ss = s.Split(new string[] { ", " }, StringSplitOptions.None);
            if (ss.Length < 2) continue;
            int dvalue;
            if (int.TryParse(ss[1], out dvalue)) {
                pairList[ss[0]] = dvalue;
            }
        }
        return pairList;
    }
    private static object GetIntString(object[] value) {

        Dictionary<int, string> pairList = new Dictionary<int, string>();
        for (int i = 0; i < value.Length; i++) {

            string s = value[i].ToString();
            s = s.Replace("{", "");
            s = s.Replace("[", "");
            s = s.Replace("]", "");
            s = s.Replace("}", "");
            string[] ss = s.Split(new string[] { ", " }, StringSplitOptions.None);
            if (ss.Length < 2) continue;
            int dkey;
            if (int.TryParse(ss[0], out dkey)) {
                pairList[dkey] = ss[1];
            }
        }
        return pairList;
    }
    private static object GetIntInt(object[] value) {

        Dictionary<int, int> pairList = new Dictionary<int, int>();
        for (int i = 0; i < value.Length; i++) {

            string s = value[i].ToString();
            s = s.Replace("{", "");
            s = s.Replace("[", "");
            s = s.Replace("]", "");
            s = s.Replace("}", "");
            string[] ss = s.Split(new string[] { ", " }, StringSplitOptions.None);
            if (ss.Length < 2) continue;
            int dkey;
            int dvalue;
            if (int.TryParse(ss[0], out dkey) && int.TryParse(ss[1], out dvalue)) {
                pairList[dkey] = dvalue;
            }
        }
        return pairList;
    }
}
