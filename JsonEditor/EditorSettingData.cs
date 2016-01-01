using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EditorSettingData {

    public bool IsAutoSave { get; set; }

    public EditorSettingData() { }

    public EditorSettingData(bool isAutoSave) {
        IsAutoSave = isAutoSave;
    }
}
