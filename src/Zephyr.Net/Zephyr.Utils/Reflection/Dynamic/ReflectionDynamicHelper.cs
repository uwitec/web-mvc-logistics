using System;
using System.Reflection;

namespace Zephyr.Utils
{
    //public static class PrivateReflectionUsingDynamicExtensions
    public static partial class ReflectionHelper
    {
        public static dynamic ToDynamic(object o)
        {
            // Don't wrap primitive types, which don't have many interesting internal APIs
            if (o == null || o.GetType().IsPrimitive || o is string)
                return o;

            return new PrivateReflectionDynamicObjectInstance(o);
        }

        public static dynamic ToDynamicType(Type type)
        {
            return new PrivateReflectionDynamicObjectStatic(type);
        }

        public static dynamic GetDynamicType(Assembly assembly, string typeName)
        {
            //return assembly.GetType(typeName).AsDynamicType();
            return ReflectionHelper.ToDynamicType(assembly.GetType(typeName));
        }

        public static dynamic CreateDynamicInstance(Assembly assembly, string typeName, params object[] args)
        {
            //return assembly.GetDynamicType(typeName).New(args);
            return ReflectionHelper.GetDynamicType(assembly, typeName).New(args);
        }
    }
}
