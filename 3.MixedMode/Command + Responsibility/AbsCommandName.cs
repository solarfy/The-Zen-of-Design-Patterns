using System;

namespace MixedMode.Command_Responsibility
{
    //抽象命令类
    abstract class AbsCommandName
    {
        private AbsCommandName nextOperator;

        [Obsolete("单参数命令", false)]
        public string HandleMessage_Old(CommandVO vo)
        {
            //处理结果
            string result = string.Empty;
            //判断是否是自己处理的参数；如果不是则交由next处理
            if (vo.GetParam().Count == 0 || vo.GetParam().Contains(GetOperateParam()))
            {
                result = Echo(vo);                
            }
            else
            {
                if (nextOperator != null)
                {
                    result = nextOperator.HandleMessage(vo);
                }
                else
                {
                    result = "命令无法执行";
                }                
            }

            return result;
        }

        public string HandleMessage(CommandVO vo)
        {
            //处理结果
            string result = string.Empty;
            //判断是否是自己处理的参数；如果不是则交由next处理
            if (vo.GetParam().Count == 0 || vo.GetParam().Contains(GetOperateParam()))
            {
                result = Echo(vo);                
            }

            result += nextOperator?.HandleMessage(vo);  //处理完后继续交由下级处理 如：ls -a -l

            return result;
        }

        public void SetNext(AbsCommandName _nextOperator)
        {
            this.nextOperator = _nextOperator;
        }

        //每个处理者都有处理一个后缀参数
        protected abstract string GetOperateParam();

        //每个处理者都必须实现的处理任务
        protected abstract string Echo(CommandVO vo);
    }

    //抽象的ls命令
    abstract class AbsLSCommandName : AbsCommandName
    {
        //默认参数 （例：ls）
        public static string DEFAULT_PARAM = " ";   //空格
        //参数a （例：ls -a）
        public static string A_PARAM = "a";
        //参数l （例：ls -l）
        public static string L_PARAM = "l";
    }

    //抽象的df命令
    abstract class AbsDFCommandName : AbsCommandName
    {
        //默认参数 （空格）
        public static string DEFAULT_PARAM = " ";
        //参数k
        public static string K_PARAM = "k";
        //参数g
        public static string G_PARAM = "g";
    }
}
