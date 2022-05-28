using System;

namespace DesignPatternPK.Cmd_VS_Strategy.Cmd
{
    class GzipReceiver : IReceiver
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
