namespace DesignPatternPK.Strategy_VS_Bridge.Bridge
{
    //Postfix邮件服务器
    class Postfix : AbsMailServer
    {
        public override void SendMail(AbsMailTemplate m)
        {
            //增加邮件服务器信息
            string context = "Received: from XXX (unknow [xxx.xxx.xxx.xxx]) by aaa.aaa.com (Postfix) with ESMTP id 8DBCD172B8\n";
            m.Sign(context);
            base.SendMail(m);
        }
    }
}
