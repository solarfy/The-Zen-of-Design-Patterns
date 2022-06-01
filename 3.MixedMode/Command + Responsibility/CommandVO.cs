using System;
using System.Collections.Generic;
using System.Text;

namespace MixedMode.Command_Responsibility
{
    //命令对象
    class CommandVO
    {
        //定义参数名与参数的分隔符号，一般是空格
        public static string DIVIDE_FLAG = " ";
        //定义参数前的符号，UNIX一般是"-"，如ls -la "..\user"
        public static string PREFIX = "-";
        //命令名
        private string commandName;
        //参数列表
        private List<string> paramList = new() { };
        //操作数列表
        private List<string> dataList = new() { };

        //通过构造函数传递进来命令
        public CommandVO(string commandStr)
        {
            if (string.IsNullOrEmpty(commandStr))
            {
                Console.WriteLine("命令解析失败，必须传递一个命令才能执行");
            }
            else
            {
                //根据分隔符拆分出执行符号
                string[] complexStr = commandStr.Split(DIVIDE_FLAG);
                //第一个参数是执行符号
                commandName = complexStr[0];
                //把参数放入到List中
                for (int i = 1; i < complexStr.Length; i++)
                {
                    string str = complexStr[i];
                    //包含前缀符号，认为是参数；否则就认为是操作数
                    if (str.Contains(PREFIX))
                    {
                        str = str.Replace(PREFIX, string.Empty).Trim();

                        //拆分命令参数；如ls -la 拆分成参数l和参数a
                        foreach (char c in str)
                            paramList.Add(c.ToString());
                    }
                    else
                        dataList.Add(str.Trim());
                }
            }
        }

        //获得命令名
        public string GetCommandName()
        {
            return commandName.ToLower();
        }

        //获取参数
        public List<string> GetParam()
        {
            //为了方便处理空参数
            if (paramList.Count == 0)
                paramList.Add(" ");

            //HashSet：元素是没有顺序的；元素具有唯一性（不允许有重复的元素）
            return new List<string>(new HashSet<string>(paramList));    //避免有两个相同的参数，比如“ls -l -l -s”这样的命令
        }

        //获取操作数
        public List<string> GetData()
        {
            return dataList;
        }

        //将操作数连接成一个字符串
        public string FormatData()
        {
            StringBuilder sb = new StringBuilder(10);

            foreach (string s in dataList)
            {
                sb.Append(sb);
            }

            return sb.ToString();
        }
    }
}
