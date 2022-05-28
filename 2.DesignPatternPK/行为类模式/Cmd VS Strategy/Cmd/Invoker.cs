namespace DesignPatternPK.Cmd_VS_Strategy.Cmd
{
    //命令调用者
    class Invoker
    {
        //抽象命令的引用
        private AbsCmd cmd;

        public Invoker(AbsCmd _cmd) => this.cmd = _cmd;

        public bool Execute(string source, string to)
        {
            return cmd.Execute(source, to);
        }
    }
}
