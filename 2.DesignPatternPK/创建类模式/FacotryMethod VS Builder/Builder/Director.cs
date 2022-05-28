namespace DesignPatternPK.FacotryMethod_VS_Builder.Builder
{
    class Director
    {
        //创建成年的超人
        public static SuperMan CreateAdultSuperMan()
        {
            return new AdultSuperManBuilder().CreateSuperMan();
        }

        //创建未成年的超人
        public static SuperMan CreateChildSuperMan()
        {
            return new ChildSuperManBuilder().CreateSuperMan();
        }
    }
}
