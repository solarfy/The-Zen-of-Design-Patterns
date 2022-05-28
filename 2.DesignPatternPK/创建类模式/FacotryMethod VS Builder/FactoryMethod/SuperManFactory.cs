namespace DesignPatternPK.FacotryMethod_VS_Builder.FactoryMethod
{
    //超人工厂
    class SuperManFactory
    {
        //超人生成工厂
        public static ISuperMan CreateSuperMan<T>() where T : ISuperMan
        {
            ISuperMan superMan = null;

            if (typeof(T) == typeof(ChildSuperMan))
                superMan = new ChildSuperMan();
            else if (typeof(T) == typeof(AdultSuperMan))
                superMan = new AdultSuperMan();

            return superMan;
        }
    }
}
