namespace MixedMode.Command_Responsibility
{
    static class DiskManager
    {
        public static string DF()
        {
            return "/t10485760\n/user\t104857600\n/home\t1048576000\n";
        }

        public static string DF_K()
        {
            return "/\t10240\n/user\t102400\n/home\tt10240000\n";
        }

        public static string DF_G()
        {
            return "/\t10\n/user\t100\n/home\tt10000\n";
        }
    }
}
