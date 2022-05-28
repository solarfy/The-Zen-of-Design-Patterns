namespace ZenOfDesignPattern.Builder_Pattern
{
    //导演类；起到封装的作用，避免高层模块深入到建造者内部的实现类；如果项目较大时，导演类可以有多个。
    class Director
    {
        private Builder builder = new Builder();

        //构建不同的产品
        public Product GetProduct()
        {
            builder.SetPart();

            //设置不同的零件，产生不同的产品

            return builder.BuildProduct();
        }
    }
}
