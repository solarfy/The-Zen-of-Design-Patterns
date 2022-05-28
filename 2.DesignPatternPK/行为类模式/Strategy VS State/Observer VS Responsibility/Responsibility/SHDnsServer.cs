namespace DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Responsibility
{
    //上海DNS服务器
    class SHDnsServer : AbsDnsServer
    {
        public override bool IsLocal(string domain)
        {
            return domain.EndsWith(".sh.cn");
        }

        protected override Recorder Echo(string domain)
        {
            Recorder recorder = base.Echo(domain);
            recorder.SetOwner("上海DNS服务器");
            return recorder;
        }
    }
}
