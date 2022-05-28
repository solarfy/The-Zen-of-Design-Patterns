using System;

namespace DesignPatternPK.Cmd_VS_Strategy.Strategy
{
    //GZip压缩算法
    class Gzip : IAlgorithm
    {
        public bool Compress(string source, string to)
        {
            Console.WriteLine($"{source} --> {to} GZIP压缩成功");
            return true;
        }

        public bool Uncompress(string source, string to)
        {
            Console.WriteLine($"{source} --> {to} GZIP解压缩成功");
            return true;
        }
    }
}
