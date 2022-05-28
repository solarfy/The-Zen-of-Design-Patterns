namespace DesignPatternPK.Cmd_VS_Strategy.Cmd
{
    //抽象命令接收者
    interface IReceiver
    {
        //压缩
        bool Compress(string source, string to);

        //解压缩
        bool Uncompress(string source, string to);
    }
}
