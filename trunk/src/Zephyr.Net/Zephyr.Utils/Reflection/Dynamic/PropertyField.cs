using System.Reflection;

namespace Zephyr.Utils
{
    // IProperty implementation over a PropertyInfo
    class Property : IProperty
    {
        internal PropertyInfo PropertyInfo { get; set; }

        string IProperty.Name
        {
            get
            {
                return PropertyInfo.Name;
            }
        }

        object IProperty.GetValue(object obj, object[] index)
        {
            return PropertyInfo.GetValue(obj, index);
        }

        void IProperty.SetValue(object obj, object val, object[] index)
        {
            PropertyInfo.SetValue(obj, val, index);
        }
    }

    // IProperty implementation over a FieldInfo
    class Field : IProperty
    {
        internal FieldInfo FieldInfo { get; set; }

        string IProperty.Name
        {
            get
            {
                return FieldInfo.Name;
            }
        }

        object IProperty.GetValue(object obj, object[] index)
        {
            return FieldInfo.GetValue(obj);
        }

        void IProperty.SetValue(object obj, object val, object[] index)
        {
            FieldInfo.SetValue(obj, val);
        }
    }

    // Simple abstraction to make field and property access consistent
    interface IProperty
    {
        string Name { get; }
        object GetValue(object obj, object[] index);
        void SetValue(object obj, object val, object[] index);
    }
}
