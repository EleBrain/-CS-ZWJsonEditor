using System.ComponentModel;

public class SerializableExpandableObjectConverter : ExpandableObjectConverter {

    public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType) {
        if ((destinationType == typeof(string))) {
            return false;
        } else {
            return base.CanConvertTo(context, destinationType);
        }

    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType) {
        if ((sourceType == typeof(string))) {
            return false;
        } else {
            return base.CanConvertFrom(context, sourceType);
        }

    }
}