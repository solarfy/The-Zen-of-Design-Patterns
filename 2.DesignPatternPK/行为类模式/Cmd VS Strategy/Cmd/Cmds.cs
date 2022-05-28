namespace DesignPatternPK.Cmd_VS_Strategy.Cmd
{
    class ZipComressCmd : AbsCmd
    {
        public override bool Execute(string source, string to)
        {
            return base.zip.Compress(source, to);
        }
    }

    class ZipUncompressCmd : AbsCmd
    {
        public override bool Execute(string source, string to)
        {
            return base.zip.Uncompress(source, to);
        }
    }

    class GzipCompressCmd : AbsCmd
    {
        public override bool Execute(string source, string to)
        {
            return base.gzip.Compress(source, to);
        }
    }

    class GzipUncompressCmd : AbsCmd
    {
        public override bool Execute(string source, string to)
        {
            return base.gzip.Uncompress(source, to);
        }
    }
}
