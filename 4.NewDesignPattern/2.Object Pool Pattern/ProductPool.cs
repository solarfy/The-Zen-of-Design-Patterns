using System;

namespace NewDesignPattern.Object_Pool_Pattern
{
    class ProductPool : ObjectPool<Product>
    {
        private static void CreateProductAction(Product p)
        {
            Console.WriteLine($"创建产品 {p}");
        }

        private static void ReleaseProductAction(Product p)
        {
            Console.WriteLine($"回收产品 {p}");
        }

        public ProductPool() : base(CreateProductAction, ReleaseProductAction)
        {

        }
    }
}
