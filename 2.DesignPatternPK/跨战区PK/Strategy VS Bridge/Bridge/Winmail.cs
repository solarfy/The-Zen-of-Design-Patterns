namespace DesignPatternPK.Strategy_VS_Bridge.Bridge
{
    //Winmail邮件服务器
    class Winmail : AbsMailServer
    {
        public override void SendMail(AbsMailTemplate m)
        {
            //增加邮件服务器信息
            string context = "Received: (winmail); 7 Nov 2009 04:14:44 + 0100\n";
            m.Sign(context);
            base.SendMail(m);
        }
    }
}
