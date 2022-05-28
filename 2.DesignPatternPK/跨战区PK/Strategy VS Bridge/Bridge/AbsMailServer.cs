﻿using System;

namespace DesignPatternPK.Strategy_VS_Bridge.Bridge
{
    //邮件服务器
    abstract class AbsMailServer
    {
        public virtual void SendMail(AbsMailTemplate m)
        {
            Console.WriteLine($"发件人：{m.From}");
            Console.WriteLine($"收件人：{m.To}");
            Console.WriteLine($"邮件标题：{m.Subject}");
            Console.WriteLine($"邮件内容：{m.Context}");
        }
    }
}
