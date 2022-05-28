namespace DesignPatternPK.Strategy_VS_State.Strategy
{
    //环境角色
    class Context
    {
        AbsWorkAlgorithm workAlgorithm;

        public void SetWork(AbsWorkAlgorithm algorithm) => this.workAlgorithm = algorithm;

        public AbsWorkAlgorithm GetWork() => workAlgorithm;

        public void Work()
        {
            this.workAlgorithm.Work();
        }
    }
}
