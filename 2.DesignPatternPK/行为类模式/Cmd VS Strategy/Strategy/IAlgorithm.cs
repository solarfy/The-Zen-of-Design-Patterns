namespace DesignPatternPK.Cmd_VS_Strategy.Strategy
{
    //抽象压缩算法
    interface IAlgorithm
    {
        //压缩算法
        bool Compress(string source, string to);

        //解压缩算法
        bool Uncompress(string source, string to);
    }
}
