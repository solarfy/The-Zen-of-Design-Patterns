namespace DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Responsibility
{
    class Recorder
    {
        //域名
        private string domain;
        //ip地址
        private string ip;
        //属主
        private string owner;

        public string GetDomain() => domain;
        public void SetDomain(string _domain) => domain = _domain;

        public string GetIp() => ip;
        public void SetIp(string _ip) => ip = _ip;

        public string GetOwner() => owner;
        public void SetOwner(string _owner) => owner = _owner;

        public override string ToString()
        {
            return $"域名：{domain} \nIP地址：{ip} \n解析者：{owner}";
        }
    }
}
