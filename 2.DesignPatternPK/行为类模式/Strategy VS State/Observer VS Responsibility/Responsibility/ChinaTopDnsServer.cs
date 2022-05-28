namespace DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Responsibility
{
    //中国顶级DNS服务器
    class ChinaTopDnsServer : AbsDnsServer
    {
        public override bool IsLocal(string domain)
        {
            return domain.EndsWith(".cn");
        }

        protected override Recorder Echo(string domain)
        {
            Recorder recorder = base.Echo(domain);
            recorder.SetOwner("中国顶级DNS服务器");
            return recorder;
        }
    }
}
