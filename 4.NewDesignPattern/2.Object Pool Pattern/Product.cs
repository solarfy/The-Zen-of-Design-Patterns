using System;

namespace NewDesignPattern.Object_Pool_Pattern
{
    class Product
    {
        //产品编号
        public string Code { get; set; }

        //产品名称
        public string Name { get; set; }

        //where T : new()  必须实现一个无参构造函数
        public Product()
        {
            Code = DateTime.Now.ToString("yyyyMMddHHmmss");
            Name = DateTime.Now.ToString("F");
        }

        public override string ToString()
        {
            return $"编号：{Code}\t名称：{Name}";
        }
    }
}
