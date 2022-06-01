using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedMode.Command_Responsibility
{
    static class ClassUtils
    {
        //获取一个类所在程序集中的所有子类
        public static List<Type> GetSubClasses(Type parentType)
        {
            var subTypeList = new List<Type>();
            var assembly = parentType.Assembly;     //获取当前父类所在程序集
            var assemblyAllTypes = assembly.GetTypes();  //获取该程序集中所有类型

            foreach (var itemType in assemblyAllTypes)
            {
                var baseType = itemType.BaseType;   //获取基类

                if (baseType != null && baseType.Name == parentType.Name)   //如果有基类且与父类名相同
                {
                    subTypeList.Add(itemType);  //加入子类列表中
                }
            }

            return subTypeList;
        }

        //获取一个类所在程序集中的所有子类名称
        public static List<string> GetSubClassNames(Type parentType)
        {
            var subTypeList = GetSubClasses(parentType);           
            return subTypeList.Select(item => item.Name).ToList();  //获取所有子类类型的名称
        }        
    }
}
