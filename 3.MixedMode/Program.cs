using System;
using CR = MixedMode.Command_Responsibility;
using FMS = MixedMode.FactoryMethod_Srategy;
using OM = MixedMode.Observer_Mediator;

namespace MixedMode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 命令模式 + 责任链模式            
            /* 责任链模式：负责对命令的参数进行解析，而且所有的扩展都是增加链数量和节点，不涉及原有的代码变更。
             * 命令模式：负责命令的分发，把适当的命令分发到指定的链上。
             * 模板方法：AbsCommandExec中的BuildChain以及AbsCommandName的HanldMessage。减少重复的代码。
             */
            //Console.WriteLine(CR.Invoker.Exec("ls"));
            //Console.WriteLine(CR.Invoker.Exec("ls -l -a"));
            //Console.WriteLine(CR.Invoker.Exec("ls -al"));
            //Console.WriteLine(CR.Invoker.Exec("df"));
            //Console.WriteLine(CR.Invoker.Exec("df -k -g"));
            //Console.WriteLine(CR.Invoker.Exec("df -kg"));
            #endregion

            #region 策略模式 + 工厂方法模式
            /* 策略模式：负责对扣款策略进行封装，保证两个策略可以自由切换。
             * 工厂方法模式：修正策略模式必须对外暴露具体策略的问题，由工厂方法模式直接产生一个具体策略对象。
             * 门面模式：负责对整个扣款系统进行封装；避免高层模块深入子系统内部。             
             */
            //FMS.Card card = new FMS.Card("0001", 50000, 30000);     //IC卡 500元，300元
            //FMS.Trade trade = new FMS.Trade("20220530", 12000);     //交易 120元
            //Console.WriteLine(card);
            //Console.WriteLine(trade);
            //Console.WriteLine("使用扣款策略一：");
            //card = FMS.DeductionFacade.SteadyDeduct(card, trade);
            //Console.WriteLine(card);
            //Console.WriteLine("使用扣款策略二：");
            //card = FMS.DeductionFacade.FreeDeduct(card, trade);
            //Console.WriteLine(card);
            #endregion

            #region 观察者模式 + 中介者模式
            /* 工厂方法模式：负责产生产品对象，方便产品的修改和扩展，并且实现了产品和工厂的紧耦合，避免产品随意被创建而无触发事件的情况发生。
             * 桥梁模式：产品和事件，两者可以自由地扩展而不破坏原有地封装。
             * 观察者模式：解决了事件如何通知处理者地问题。
             * 中介者模式：耦合处理者和事件之间地关系。
             */ 
            //OM.EventDispatch dispatch = OM.EventDispatch.GetEventDispatch();        //获得事件分发者（中介者）
            //dispatch.RegisterCustomer(new OM.Beggar());     //添加事件处理者：乞丐，平民，贵族；每个处理者之间事件处理权限不同
            //dispatch.RegisterCustomer(new OM.Commoner());
            //dispatch.RegisterCustomer(new OM.Nobleman());
            
            //OM.ProductManager factory = new();  //原子弹生产工厂
            //OM.Product product = factory.CreateProduct("小男孩原子弹");   //创建一个小男孩原子弹
            //factory.EidtProduct(product, "胖子号原子弹");     //将小男孩原子弹更名为胖子号原子弹
            //OM.Product productClone = factory.Clone(product);   //克隆一个原子弹
            //factory.AbandonProduct(product);            //将胖子号原子弹丢弃
            #endregion
        }
    }
}
