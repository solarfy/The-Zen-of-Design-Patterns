namespace DesignPatternPK.Cmd_VS_Strategy.Strategy
{
    //环境角色
    class Context
    {
        //指定的算法
        private IAlgorithm algorithm;

        public Context(IAlgorithm _algorithm) => this.algorithm = _algorithm;

        //执行压缩算法
        public bool Compress(string source, string to)
        {
            return algorithm.Compress(source, to);
        }

        //执行解压缩算法
        public bool Uncompress(string source, string to)
        {
            return algorithm.Uncompress(source, to);
        }
    }
}
