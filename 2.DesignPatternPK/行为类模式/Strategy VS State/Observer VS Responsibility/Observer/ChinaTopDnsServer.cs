using Recorder = DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Responsibility.Recorder;

namespace DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Observer
{
    class ChinaTopDnsServer : AbsDnsServer
    {
        protected override bool IsLocal(Recorder recorder)
        {
            return recorder.GetDomain().EndsWith(".cn");
        }

        protected override void Sign(Recorder recorder)
        {
            recorder.SetOwner("中国顶级DNS服务器");
        }
    }
}
