using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;

public class DictionaryConverter : TypeConverter {

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
        return false;
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) {
        if (value == null) return base.ConvertTo(context, culture, value, destinationType);

        Type k = value.GetType().GetGenericArguments()[0];
        Type v = value.GetType().GetGenericArguments()[1];

        string s = "";
        if (k == typeof(string) && v == typeof(string)) {
            Dictionary<string, string> d = (Dictionary<string, string>)value;
            foreach (var item in d) {
                s += item.Key + ", " + item.Value + " | ";
            }
        } else if (k == typeof(string) && v == typeof(int)) {
            Dictionary<string, int> d = (Dictionary<string, int>)value;
            foreach (var item in d) {
                s += item.Key + ", " + item.Value + " | ";
            }
        } else if (k == typeof(int) && v == typeof(string)) {
            Dictionary<int, string> d = (Dictionary<int, string>)value;
            foreach (var item in d) {
                s += item.Key + ", " + item.Value + " | ";
            }
        } else if (k == typeof(int) && v == typeof(int)) {
            Dictionary<int, int> d = (Dictionary<int, int>)value;
            foreach (var item in d) {
                s += item.Key + ", " + item.Value + " | ";
            }
        } else {
            return base.ConvertTo(context, culture, value, destinationType);
        }

        return s;
    }
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) {
        return false;
    }

    //public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) {
    //    StringReader sr = new StringReader(((string)value));
    //    Dictionary<string, int> d = new Dictionary<string, int>();
    //    while (sr.Peek() > -1) {
    //        string s = sr.ReadLine();
    //        string[] ss = (s).Split(new char[] { ',' });

    //        d.Add(ss[0], int.Parse(ss[1]));
    //    }
    //    return d;
    //}

}

