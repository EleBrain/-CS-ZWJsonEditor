using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Reflection;
using System.Globalization;
using System.IO;

class DictionaryConverter : TypeConverter {
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
        return true;
    }
    public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {
        if(value == null) return base.ConvertTo(context, culture, value, destinationType);
        Dictionary<string, int> d = (Dictionary<string, int>)value;
        string s = "";
        foreach (var item in d) {
            s += item.Key + ", " + item.Value + "\r\n";
        }
        return s;
    }
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) {
        return true;
    }
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) {
        StringReader sr = new StringReader(((string)value));
        Dictionary<string, int> d = new Dictionary<string, int>();
        while (sr.Peek() > -1) {
            string s = sr.ReadLine();
            string[] ss = (s).Split(new char[] { ',' });

            d.Add(ss[0], int.Parse(ss[1]));
        }
        return d;
    }

    
}

