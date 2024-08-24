using System.ComponentModel;
using System.Reflection;
using System.Xml.Serialization;

namespace DanfeFluentBlazor.Extensions;

public static class EnumExtensions
{
    public static string GetDescription(this Enum enumValue)
    {
        var field = enumValue.GetType().GetField(enumValue.ToString());
        if (field == null)
            return enumValue.ToString();

        var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
        if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
        {
            return attribute.Description;
        }

        return enumValue.ToString();
    }

    public static string GetXmlEnumValue(Enum enumValue)
    {
        FieldInfo fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
        XmlEnumAttribute[] attributes = (XmlEnumAttribute[])fieldInfo.GetCustomAttributes(typeof(XmlEnumAttribute), false);

        if (attributes.Length > 0)
        {
            return attributes[0]?.Name!;
        }

        return string.Empty;
    }
}
