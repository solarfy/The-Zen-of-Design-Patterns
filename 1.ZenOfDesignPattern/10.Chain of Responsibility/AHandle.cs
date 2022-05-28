using System;

namespace ZenOfDesignPattern.Chain_of_Responsibility
{
    //抽象处理者
    public abstract class AHandle
    {        
        //处理者的级别
        public Levels Level { get; protected set; }
        //下一个处理者
        public AHandle NextHandle { private get; set; } = null;

        //每个处理者必须实现的逻辑处理
        public abstract void DoSomething(Request request);

        public void HandleDoSomething(Request request)
        {
            if (this.Level == request.Level)
                this.DoSomething(request);  //调用的是指定的DoSomething
            else
            {
                if (this.NextHandle != null)
                    this.NextHandle.HandleDoSomething(request);     //注：调用下一个节点的HandleDoSomething，并不是DoSomething
                else
                    Console.WriteLine("没有适当的处理者，业务自行处理。");
            }

        }
    }
}
