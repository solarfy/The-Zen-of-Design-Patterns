namespace MixedMode.Command_Responsibility
{
    //文件管理类；模拟出ls系命令结果
    class FileManager
    {
        //ls命令
        public static string LS(string path)
        {
            return "file1\nfile2\nfile3\n";
        }

        //ls -l命令
        public static string LS_L(string path)
        {
            return "drw-rw-rw root system 1024 2022-5-29 13:31 file1\n"
                 + "drw-rw-rw root system 1024 2022-5-29 13:31 file2\n"
                 + "drw-rw-rw root system 1024 2022-5-29 13:31 file3\n";
        }

        //ls -a命令
        public static string LS_A(string path)
        {
            return ".\n..\nfile1\nfile2\nfile3\n";
        }
    }
}
