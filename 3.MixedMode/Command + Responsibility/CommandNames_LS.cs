namespace MixedMode.Command_Responsibility
{
    //ls命令
    class LS : AbsLSCommandName
    {
        //
        protected override string Echo(CommandVO vo)
        {
            return FileManager.LS(vo.FormatData());
        }

        //ls的参数为空
        protected override string GetOperateParam()
        {
            return AbsLSCommandName.DEFAULT_PARAM;
        }
    }

    //ls -l命令
    class LS_L : AbsLSCommandName
    {
        protected override string Echo(CommandVO vo)
        {
            return FileManager.LS_L(vo.FormatData());
        }

        //ls -l的参数为l
        protected override string GetOperateParam()
        {
            return AbsLSCommandName.L_PARAM;
        }
    }

    //ls -a命令
    class LS_A : AbsLSCommandName
    {
        protected override string Echo(CommandVO vo)
        {
            return FileManager.LS_A(vo.FormatData());
        }

        //ls -a的参数为a
        protected override string GetOperateParam()
        {
            return AbsLSCommandName.A_PARAM;
        }
    }
}
