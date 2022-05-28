namespace DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Responsibility
{
    //顶级DNS服务器
    class TopDnsServer : AbsDnsServer
    {
        public override bool IsLocal(string domain)
        {
            return true;    //最顶级了只能为true
        }

        protected override Recorder Echo(string domain)
        {
            Recorder recorder = base.Echo(domain);
            recorder.SetOwner("全球顶级DNS服务器");
            return recorder;
        }
    }
}
