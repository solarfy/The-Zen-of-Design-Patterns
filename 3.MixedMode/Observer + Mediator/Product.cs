using System;

namespace MixedMode.Observer_Mediator
{
    class Product : ICloneable
    {
        //是否允许变更属性
        private bool canChanged = false;

        private string name;
        //产品名称
        public string Name 
        {
            get => name;
            set 
            {
                if (canChanged)
                    name = value;
            }
        }


        public Product(ProductManager manager, string _name)
        {
            //只能通过ProductManager创建产品
            if (manager.IsPermittedCreate)
            {
                canChanged = true;  //只有通过ProductManager创建的产品，才具有修改属性的权限
                Name = _name;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
