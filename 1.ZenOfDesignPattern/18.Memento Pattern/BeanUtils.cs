using System;
using System.Collections.Generic;
using System.Reflection;

namespace ZenOfDesignPattern.Memento_Pattern
{
    static class BeanUtils
    {
        public static Dictionary<string, object> BackupProp(object bean)
        {
            Dictionary<string, object> result = new Dictionary<string, object>() { };

            Type target = bean.GetType();
            PropertyInfo[] infos = target.GetProperties();

            try
            {
                foreach (var p in infos)
                {
                    if (p.MemberType == MemberTypes.Property)
                    {
                        result[p.Name] = p.GetValue(bean);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine($"BackupProp Error: {exc.Message}");
            }

            return result;
        }

        public static void RestoreProp(object bean, Dictionary<string, object> keyValues)
        {
            Type target = bean.GetType();
            PropertyInfo[] infos = target.GetProperties();

            try
            {
                foreach (var p in infos)
                {
                    if (p.MemberType == MemberTypes.Property)
                    {
                        if (keyValues.ContainsKey(p.Name))
                            p.SetValue(bean, keyValues[p.Name]);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine($"RestoreProp Error: {exc.Message}");
            }
        }
    }
}
