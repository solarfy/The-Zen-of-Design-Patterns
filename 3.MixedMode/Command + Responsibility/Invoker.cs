namespace MixedMode.Command_Responsibility
{
    //命令分发
    class Invoker
    {
        public static string Exec(string commandStr)
        {
            //定义返回值
            string result = string.Empty;
            //解析命令
            CommandVO vo = new CommandVO(commandStr);

            //AbsLSCommandName ls = new LS();
            //AbsLSCommandName ls_l = new LS_L();
            //AbsLSCommandName ls_a = new LS_A();

            //ls.SetNext(ls_l);
            //ls_l.SetNext(ls_a);

            //result = ls.HandleMessage(vo);

            //AbsCommandExec exec = new LSCommandExec();   //自动建立一个ls命令族责任链表
            //result = exec.Exec(vo);

            //检查是否支持该命令
            if (CommandEnum.HasCommand(vo.GetCommandName()))
            {
                //创建一个命令对象实例
                AbsCommandExec exec = CommandEnum.CreateCommandExec(vo.GetCommandName());
                result = exec.Exec(vo);
            }
            else
            {
                result = "未找到该命令";
            }

            return result;
        }
    }
}
