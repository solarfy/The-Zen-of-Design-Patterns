using System;

namespace ZenOfDesignPattern.Composite_Pattern
{
    class Client
    {
        //public ObsolietAttribute(string message, bool error)  //标记废弃方法
        //message:提示信息  error:true-编译器错误 false-编译器警告

        [Obsolete("该方法不再使用", false)]
        public static void CreateTree()
        {
            //创建一个跟节点
            Composite root = new();
            root.DoSomething();

            //创建两个个树枝构件
            Composite branch1 = new();
            Composite branch2 = new();

            //创建三个叶子构件
            Leaf leaf1 = new();
            Leaf leaf2 = new();
            Leaf leaf3 = new();

            //建立整体
            root.Add(branch1);
            root.Add(branch2);            
            branch1.Add(leaf1);
            branch1.Add(leaf2);
            branch2.Add(leaf3);

            Display(root);
        }

        public static void Display(Composite root)
        {
            foreach (AComponent cmp in root.GetChildren())
            {
                cmp.DoSomething();
                if (cmp is Composite composite)
                    Display(composite);
            }
        }
    }
}
