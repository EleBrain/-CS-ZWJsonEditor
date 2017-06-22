using System;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.ComponentModel;

internal class ColorEditor : UITypeEditor {

    //描画を有効にする
    public override bool GetPaintValueSupported(ITypeDescriptorContext context) {
        return true;
    }

    //塗りつぶし
    public override void PaintValue(PaintValueEventArgs e) {
        if (e.Value == null) return;
        Color color = ColorTranslator.FromHtml(e.Value.ToString());
        e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds);
    }
    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) {
        return UITypeEditorEditStyle.Modal;
    }

    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) {
        ColorDialog d = new ColorDialog();
        if (d.ShowDialog() == DialogResult.OK) {
            return ColorTranslator.ToHtml(Color.FromArgb(d.Color.ToArgb()));
        }
        return value;
    }
}