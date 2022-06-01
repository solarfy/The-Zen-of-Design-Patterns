namespace MixedMode.Command_Responsibility
{
    //df族命令具体实现
    class DF : AbsDFCommandName
    {
        protected override string Echo(CommandVO vo)
        {
            return DiskManager.DF();
        }

        protected override string GetOperateParam()
        {
            return AbsDFCommandName.DEFAULT_PARAM;
        }
    }

    //df -k
    class DF_K : AbsDFCommandName
    {
        protected override string Echo(CommandVO vo)
        {
            return DiskManager.DF_K();
        }

        protected override string GetOperateParam()
        {
            return AbsDFCommandName.K_PARAM;
        }
    }

    //df -g
    class DF_G : AbsDFCommandName
    {
        protected override string Echo(CommandVO vo)
        {
            return DiskManager.DF_G();
        }

        protected override string GetOperateParam()
        {
            return AbsDFCommandName.G_PARAM;
        }
    }
}
