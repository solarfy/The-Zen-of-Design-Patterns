using System;
using System.Collections.Generic;
using System.Reflection;

namespace MixedMode.Command_Responsibility
{
    //抽象命令执行类；通过该类创建命令的处理链
    abstract class AbsCommandExec
    {
        //命令执行
        public abstract string Exec(CommandVO vo);

        //建立命令处理责任链 （此处使用泛型是为了限制T必须为AbsCommandName的子类）
        protected List<AbsCommandName> BuildChain<T>() where T : AbsCommandName
        {
            //取出所有的命令名下的子类
            List<Type> classes = ClassUtils.GetSubClasses(typeof(T));
            //用于存放命令的实例
            List<AbsCommandName> commandNameList = new() { };

            foreach (Type item in classes)
            {                
                ConstructorInfo constructor = item.GetConstructor(Array.Empty<Type>());
                if (constructor != null)
                {
                    AbsCommandName commandName = (T)constructor.Invoke(null);    //无参构造函数产生一个实例

                    //建立链表，0元素为首节点
                    if (commandNameList.Count > 0)
                    {
                        commandNameList[commandNameList.Count - 1].SetNext(commandName);
                    }

                    commandNameList.Add(commandName);   //将当前实例存入
                }
            }

            return commandNameList;
        }
    }
}
