using Recorder = DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Responsibility.Recorder;

namespace DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Observer
{
    class SHDnsServer : AbsDnsServer
    {
        protected override bool IsLocal(Recorder recorder)
        {
            return recorder.GetDomain().EndsWith(".sh.cn");
        }

        protected override void Sign(Recorder recorder)
        {
            recorder.SetOwner("上海DNS服务器");
        }
    }
}
