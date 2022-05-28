using System;

namespace DesignPatternPK.Cmd_VS_Strategy.Strategy
{
    //ZIP压缩算法
    class Zip : IAlgorithm
    {
        public bool Compress(string source, string to)
        {
            Console.WriteLine($"{source} --> {to} ZIP压缩成功");
            return true;
        }

        public bool Uncompress(string source, string to)
        {
            Console.WriteLine($"{source} --> {to} ZIP解压缩成功");
            return true;
        }
    }
}
