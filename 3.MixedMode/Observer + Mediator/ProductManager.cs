namespace MixedMode.Observer_Mediator
{
    //单来源调用（Single Call）;只能通过该类创建Product的实例
    class ProductManager
    {
        //是否可以创建一个产品
        public bool IsPermittedCreate { get; set; } = false;

        //建立一个产品
        public Product CreateProduct(string name)
        {
            IsPermittedCreate = true;   //首先修改权限，允许创建
            Product p = new Product(this, name);
            new ProductEvent(p, ProductEventType.NEW_PRODUCT);    //通知创建了一个产品
            return p;
        }

        //废弃一个产品
        public void AbandonProduct(Product p)
        {
            new ProductEvent(p, ProductEventType.DEL_PRODUCT);    //通知删除了一个产品
            p = null;
        }

        //修改一个产品
        public void EidtProduct(Product p, string name)
        {
            p.Name = name;
            new ProductEvent(p, ProductEventType.EDIT_PRODUCT);    //通知修改了一个产品
        }

        //克隆一个产品
        public Product Clone(Product p)
        {
            new ProductEvent(p, ProductEventType.CLONE_PRODUCT);    //通知克隆了一个产品
            return (Product)p.Clone();
        }
    }
}
