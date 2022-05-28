using System;
using System.Collections.Generic;

namespace DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Responsibility
{
    static class Tools
    {
        //随机产生一个IP地址
        public static string CreateIpAddress()
        {
            Random random = new();
            return $"{random.Next(255)}.{random.Next(255)}.{random.Next(255)}.{random.Next(255)}";
        }

        //随机产生一组域名
        public static string[] CreateDomains()
        {
            return new string[] { "www.abc.sh.cn"
                                , "www.12345.cn" 
                                , "www.xxx.com"};           
        }

        public static List<Recorder> CreateRecorders()
        {
            List<Recorder> recorders = new List<Recorder>() { };

            foreach (string str in CreateDomains())
            {
                Recorder recorder = new();
                recorder.SetDomain(str);
                recorders.Add(recorder);
            }

            return recorders;
        }
    }
}
