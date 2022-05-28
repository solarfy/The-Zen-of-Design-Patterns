using Recorder = DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Responsibility.Recorder;

namespace DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Observer
{
    class TopDnsServer : AbsDnsServer
    {
        protected override bool IsLocal(Recorder recorder)
        {
            return true;    //所有域名最终的解析地点
        }

        protected override void Sign(Recorder recorder)
        {
            recorder.SetOwner("全球顶级DNS服务器");
        }
    }
}
