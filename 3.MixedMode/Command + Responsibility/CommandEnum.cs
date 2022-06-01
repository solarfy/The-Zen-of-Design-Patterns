using System;
using System.Reflection;
using System.Collections.Generic;

namespace MixedMode.Command_Responsibility
{
    static class CommandEnum
    {
        //建立命令字符与命令类之间的对应关系
        private static Dictionary<string, Type> commands = new()
        {
            ["ls"] = typeof(LSCommandExec),
            ["df"] = typeof(DFCommandExec)
        };

        public static bool HasCommand(string cmd)
        {
            cmd = cmd.ToLower();    //将命令都小写           
            return commands.ContainsKey(cmd);
        }

        //获取命令所对应的类
        public static Type GetCommandType(string cmd)
        {
            cmd = cmd.ToLower();    //将命令都小写
            return commands[cmd];  
        }

        //创建一个该命令所对应的实例
        public static AbsCommandExec CreateCommandExec(string cmd)
        {
            AbsCommandExec exec = null;
            Type type = GetCommandType(cmd);

            ConstructorInfo constructor = type.GetConstructor(Array.Empty<Type>());

            if (constructor != null)
                exec = (AbsCommandExec)constructor.Invoke(null);   //调用无参构造函数创建一个实例

            return exec;    
        }
    }
}
