namespace MixedMode.Command_Responsibility
{
    class LSCommandExec : AbsCommandExec
    {
        public override string Exec(CommandVO vo)
        {
            //返回链表的首节点
            AbsCommandName commandName = base.BuildChain<AbsLSCommandName>()[0];
            return commandName.HandleMessage(vo);
        }
    }

    class DFCommandExec : AbsCommandExec
    {
        public override string Exec(CommandVO vo)
        {
            AbsCommandName commandName = base.BuildChain<AbsDFCommandName>()[0];
            return commandName.HandleMessage(vo);
        }
    }
}
