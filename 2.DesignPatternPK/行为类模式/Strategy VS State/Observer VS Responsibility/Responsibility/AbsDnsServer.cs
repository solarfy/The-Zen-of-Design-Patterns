namespace DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Responsibility
{
    //抽象域名服务器
    abstract class AbsDnsServer
    {
        //上级DNS
        private AbsDnsServer upperServer;

        //设置上级服务器
        public void SetUpperServer(AbsDnsServer server) => upperServer = server;

        //解析域名
        public Recorder Resolve(string domain)
        {
            Recorder recorder;

            if (IsLocal(domain))    //如果是本服务器能够解析的，则本服务器解析；如果本服务器不能解析，则交由上级服务器解析。
                recorder = Echo(domain);
            else
                recorder = upperServer.Resolve(domain);

            return recorder;
        }

        //是否是本服务器能够解析的域名
        public abstract bool IsLocal(string domain);

        //每个服务器都必须实现解析任务
        protected virtual Recorder Echo(string domain)
        {
            Recorder recorder = new Recorder();
            recorder.SetDomain(domain);
            recorder.SetIp(Tools.CreateIpAddress());
            return recorder;
        }        
    }
}
