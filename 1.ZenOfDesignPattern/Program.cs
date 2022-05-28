using System;
using SP        = ZenOfDesignPattern.Singleton_Pattern;
using FM        = ZenOfDesignPattern.Factory_Method;
using AFP       = ZenOfDesignPattern.Abstract_Factory_Pattern;
using TMP       = ZenOfDesignPattern.Template_Method_Pattern;
using BP        = ZenOfDesignPattern.Builder_Pattern;
using PP        = ZenOfDesignPattern.Proxy_Pattern;
using PRO       = ZenOfDesignPattern.Prototype_Pattern;
using MP        = ZenOfDesignPattern.Mediator_Pattern;
using CP        = ZenOfDesignPattern.Command_Pattern;
using COR       = ZenOfDesignPattern.Chain_of_Responsibility;
using DP        = ZenOfDesignPattern.Decorator_Pattern;
using STG       = ZenOfDesignPattern.Strategy_Pattern;
using AP        = ZenOfDesignPattern.Adapter_Pattern;
using IP        = ZenOfDesignPattern.Iterator_Pattern;
using CPST      = ZenOfDesignPattern.Composite_Pattern;
using OP        = ZenOfDesignPattern.Observer_Pattern;
using FP        = ZenOfDesignPattern.Facade_Pattern;
using MMT       = ZenOfDesignPattern.Memento_Pattern;
using VP        = ZenOfDesignPattern.Visitor_Pattern;
using STA       = ZenOfDesignPattern.State_Pattern;
using ITP       = ZenOfDesignPattern.Interpreter_Pattern;
using FLY       = ZenOfDesignPattern.Flyweight_Pattern;
using BRI       = ZenOfDesignPattern.Bridge_Pattern;

namespace ZenOfDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Singleton Pattern 单例模式 | 确保某一个类只有一个实例，而且自行实例化并向整个系统提供这个实例。
            //SP.Singleton.GetSingleton().DoSomething();
            //SP.SingletonMultiple.GetInstance().DoSomething();
            #endregion

            #region 2.Facotry Method 工厂方法模式 | 定义一个用于创建对象的接口，让子类决定实例化哪一个类。
            //FM.Creator creator = new FM.Creator();
            //FM.AbstractProduct product1 = creator.CreateProduct<FM.Product1>();
            //FM.AbstractProduct product2 = creator.CreateProduct<FM.Product2>();
            //product1.Method2();
            //product2.Method2();
            #endregion

            #region 3.Abstract Factory Pattern 抽象工厂模式 | 为创建一组相关或相互依赖的对象提供一个接口，而且无需指定它们的具体类。
            //AFP.Creator1 creator1 = new AFP.Creator1(); //型号1的生产线
            //AFP.Creator2 creator2 = new AFP.Creator2(); //型号2的生产线
            //creator1.CreateProductA().DoSomething();
            //creator1.CreateProductB().DoSomething();
            //creator2.CreateProductA().DoSomething();
            //creator2.CreateProductB().DoSomething();
            #endregion

            #region 4.Template Method Pattern 模板方法模式 | 定义一个操作中算法的框架，而将一些步骤延迟到子类中。使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
            //TMP.ConcreteClassA classA = new() { EnableDoAnything = false };
            //TMP.ConcreteClassB classB = new();
            //classA.TemplateMethod();
            //classB.TemplateMethod();
            #endregion

            #region 5.Builer Pattern 建造者模式 | 将一个复杂对象的构建与它的表示分离，使得同样的构建过程中可以创建不同的表示。
            //BP.Director director = new BP.Director();   //构建一个导演类
            //BP.Product product = director.GetProduct(); //导演类中调用建造者组装产品
            //product.DoSomething();
            #endregion

            #region 6.Proxy Pattern 代理模式 | 为其他对象提供一种代理以控制对这个对象的访问。
            //PP.ISubject subject = new PP.Subject();  //被代理者-业务逻辑的具体执行者 
            //PP.ISubject proxy = new PP.Proxy(subject); //代理者
            //proxy.Request();

            //PP.ISubject proxyGeneral = new PP.Proxy_General(); //普通代理模式
            //proxyGeneral.Request();

            //PP.ISubjectCompel subjectCompel = new PP.SubjectCompel();   //强制代理模式
            //subjectCompel.Request();
            //PP.ISubjectCompel proxyCompel = subjectCompel.GetProxy();
            //proxyCompel.Request();

            //PP.ISubjectDynamic proxyDynamic = PP.Proxy_Dynamic.CreateLandlordProxy<PP.RealSubject>();  //动态代理模式            
            //proxyDynamic.Request("Hello World");
            #endregion

            #region 7.Prototype Pattern 原型模式 | 原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。
            //PRO.Subject sub1 = new PRO.Subject() { Context = "内容", Title = "标题" };
            //sub1.Part = new PRO.SubjectPart() { Count = 1 };
            //PRO.Subject sub2 = (PRO.Subject)sub1.Clone();   //通过拷贝原型创建对象
            //sub1.Part.Count = 3;    //深拷贝，不会影响到sub2的count
            //Console.WriteLine($"sub1.context = {sub1.Context}  sub1.title = {sub1.Title} sub1.count = {sub1.Part.Count}");
            //Console.WriteLine($"sub2.context = {sub2.Context}  sub2.title = {sub2.Title} sub2.count = {sub2.Part.Count}");
            #endregion

            #region 8.Mediator Pattern 中介者模式 | 用一个中介对象封装一系列的对象交互，中介者能使各对象不需要显示地相互作用，从而使耦合松散，而且可以相互独立地改变它们之间的交互。
            //MP.Mediator mediator = new();
            //MP.ColleagueA colleagueA = new(mediator); //通过构造函数将中介者注入
            //MP.ColleagueB colleagueB = new(mediator);
            //mediator.ColleagueA = colleagueA;   //将同事类注入
            //mediator.ColleagueB = colleagueB;

            //colleagueA.DepMethod(); //A中会调用B的方法，同样的B中也会调用A的方法，通过中介者，可实现低耦合。
            //colleagueB.DepMethod();
            #endregion

            #region 9.Command Pattern 命令模式 | 将一个请求封装成一个对象，从而让你使用不同的请求把客户端参数化，对请求排队或记录请求日志，可以提供命令的撤销和恢复功能。
            //CP.ReceiverA receiverA = new(); //命令接收者A
            //CP.ReveiverB reveiverB = new(); //命令接收者B
            //CP.Command1 command1 = new(receiverA);  //命令1执行接收者A的业务
            //CP.Command2 command2 = new(reveiverB);  //命令2执行接收者B的业务
            //CP.RollBackCommand rollBackCmd1 = new CP.RollBackCommand(receiverA);    //接收者A的回滚命令
            //CP.Invoker invoker = new();  //命令调度者
            //invoker.SetCommand(command1);
            //invoker.Action();   //执行命令1
            //invoker.SetCommand(command2);
            //invoker.Action();   //执行命令2
            //invoker.SetCommand(rollBackCmd1);   //执行回滚命令
            //invoker.Action();
            #endregion

            #region 10.Chain of Responsibility 责任链模式 | 使多个对象都有机会处理请求，从而避免了请求的发送者和接收者之间的耦合关系。将这些对象练成链，并沿着这条链传递该请求，知道对象处理它为止。
            //COR.Handle1 handle1 = new();    //声明所有的处理节点
            //COR.Handle2 handle2 = new();
            //COR.Handle3 handle3 = new();
            //COR.Handle4 handle4 = new();
            //handle4.NextHandle = handle3;   //设置责任链顺序 4 -> 3 -> 2 -> 1
            //handle3.NextHandle = handle2;
            //handle2.NextHandle = handle1;

            //COR.Request request;
            //for (int i = 0; i < Enum.GetValues(typeof(COR.Levels)).Length; i++)
            //{
            //    request = new COR.Request((COR.Levels)i, i.ToString());
            //    handle4.HandleDoSomething(request);     //从责任链的头开始查询
            //}
            #endregion

            #region 11.Decorator Pattern 装饰类模式 | 动态地给一个对象添加一些额外的职责。就增加功能来说，装饰模式相比生成子类更为灵活。
            //DP.AComponent component;
            //component = new DP.Component(); //最原始的构件
            //component.Operate();
            //component = new DP.DecoratorA(component);  //用A装饰原始构建
            //component.Operate();
            //component = new DP.DecoratorB(component);  //用B装饰A (Component, DecoratorA, DecoratorB都继承自抽象类AComponent)
            //component.Operate();
            #endregion

            #region 12.Strategy Pattern 策略模式 | 定义一组算法，将每个算法都封装起来，并且使它们之间可以互换。
            //STG.Context context;    //策略封装
            //context = new STG.Context(new STG.StrategyA());
            //context.DoStrategy();   //执行策略A
            //context = new STG.Context(new STG.StrategyB());
            //context.DoStrategy();   //执行策略B
            //context = new STG.Context(new STG.StrategyC());
            //context.DoStrategy();   //执行策略C
            #endregion

            #region 13.Adapter Pattern 适配器模式 | 将一个类的接口变换成客户端所期待的另一种接口，从而使原本因接口不匹配而无法在一起工作的两个类能够在一起工作。
            //AP.ITarget target;
            //target = new AP.Target();   //原有的业务
            //target.Request();
            //target = new AP.Adapter();  //通过适配器执行源角色的业务
            //target.Request();
            #endregion

            #region 14.Iterator Pattern 迭代器模式 | 提供一种方法访问容器对象中的各个元素，而又不暴露该对象的内部细节。
            //IP.ConcreteAggregate aggregate = new();  //定义一个容器
            //aggregate[0] = "123";
            //aggregate[1] = "456";
            //aggregate[2] = "789";
            //IP.Iterator iterator = aggregate.CreateIterator();  //创建该容器的迭代器
            //while (!iterator.IsDone())
            //{
            //    Console.WriteLine($"[{iterator.CurrentItem()}]");
            //    iterator.Next();
            //}
            #endregion

            #region 15.Composite Pattern 组合模式 | 将对象组合成树形结构以表示“部分-整体”的层次结构，使得用户对当个对象和组合对象的使用具有一致性。            
            //CPST.Composite root = new() { Name = "Root" };        //创建一个根节点                

            //CPST.Composite branch1 = new() { Name = "Branch1" };    //创建两个树枝构件
            //CPST.Composite branch2 = new() { Name = "Branch2" };            

            //CPST.Leaf leaf1 = new() { Name = "Leaf1" }; //创建三个叶子构件
            //CPST.Leaf leaf2 = new() { Name = "Leaf2" };
            //CPST.Leaf leaf3 = new() { Name = "Leaf3" };

            //root.Add(branch1);  //建立整体
            //root.Add(branch2);
            //branch1.Add(leaf1);
            //branch1.Add(leaf2);
            //branch2.Add(leaf3);

            //CPST.Client.Display(root);  //显示整个树            
            #endregion

            #region 16.Observer Pattern 观察者模式 | 定义对象间一种一对多的依赖关心，使得每当一个对象改变状态，则所有依赖于它的对象都会得到通知并被自动更新。
            //OP.ConcreteSubjcet subjcet = new();     //被观察者
            //OP.ConcreteObserver observer1 = new("1号观察者");
            //OP.ConcreteObserver observer2 = new("2号观察者");
            //OP.ConcreteObserver observer3 = new("3号观察者");

            //subjcet.Subscribe(observer1);   //订阅-将观察者添加入观察者容器
            //subjcet.Subscribe(observer2);
            //subjcet.Subscribe(observer3);
            //subjcet.UnSubscribe(observer2);     //取消2号观察者的订阅

            //subjcet.Cold();     //被观察者执行业务逻辑
            //subjcet.Heat();

            //subjcet.NotifyAction += observer1.OnNext;   //通过委托实现订阅
            //subjcet.NotifyAction += observer2.OnNext;
            //subjcet.NotifyAction += observer3.OnNext;
            //subjcet.NotifyAction -= observer2.OnNext;   //取消2号观察者的订阅
            //subjcet.Cool();   //委托通知  
            #endregion

            #region 17.Facade Pattern 门面模式 | 要求一个子系统的外部与其内部的通信必须通过一个统一的对象进行。
            //FP.Facade facade = new();   //定义一个门面对象
            //facade.MethodMulti();   //通过门面对象的接口访问子系统
            //FP.LittleFacade littleF = new();    //另一个权限小点的门面对象
            //littleF.MethodB();
            #endregion

            #region 18.Memento Pattern 备忘录模式 | 在不破坏封装性的前提下，捕捉一个对象的内部状态，并在该对象之外保存这个状态。这样以后就可将该对象恢复到原先保存的状态。
            //MMT.Caretaker caretaker = new();    //备忘录管理员
            //MMT.Originator originator = new();  //备份发起者、备份者
            //originator.State1 = "1";
            //originator.State2 = "2";
            //originator.State3 = "3";
            //caretaker.SetMemento("001", originator.CreateMemento());    //存档1
            //originator.State1 = "红";
            //originator.State2 = "绿";
            //originator.State3 = "蓝";
            //caretaker.SetMemento("002", originator.CreateMemento());    //存档2
            //originator.State1 = "大";
            //originator.State2 = "中";
            //originator.State3 = "小";
            //caretaker.SetMemento("003", originator.CreateMemento());    //存档3

            //originator.State1 = originator.State2 = originator.State3 = string.Empty;   //清空状态            
            //originator.RestoreMemento(caretaker.GetMemento("001"));     //恢复1号存档
            //Console.WriteLine(originator.ToString());
            //originator.RestoreMemento(caretaker.GetMemento("002"));     //恢复2号存档
            //Console.WriteLine(originator.ToString());
            //originator.RestoreMemento(caretaker.GetMemento("003"));     //恢复3号存档
            //Console.WriteLine(originator.ToString());
            #endregion

            #region 19.Visitor Pattern 访问者模式 | 封装一些作用于某种数据结构中的各元素的操作，它可以在不改变数据结构的前提下定义作用于这些元素的新的操作。
            //VP.IShowVisitor showVisitor = new VP.ShowVisitor();     //定义信息显示访问者
            //VP.ITotalVisitor totalVisitor = new VP.TotalVisitor();   //定义汇总访问者

            //for (int i = 0; i < 10; i++)
            //{
            //    VP.AbsElement element = VP.ElementFactory.Create(); //通过工厂方法创建元素
            //    element.Accept(showVisitor);    //添加访问者
            //    element.Accept(totalVisitor);
            //}

            //showVisitor.Show(); //信息显示
            //totalVisitor.TotalNumber(); //汇总
            #endregion

            #region 20.State Pattern 状态模式 | 当一个对象内在的状态改变时允许其改变行为，这个对象看起来像改变了其类。
            //STA.Context context = new();    //定义一个状态机
            //context.SetCurrentState(STA.Context.State1); //设置状态机状态-State1
            //context.Handle1();      //执行State1状态下的各部逻辑
            //Console.WriteLine($"当前状态：{context}");
            //context.Handle2();
            //Console.WriteLine($"当前状态：{context}");
            //context.Handle3();
            //Console.WriteLine($"当前状态：{context}");

            //Console.WriteLine("-------设置状态-State3-------");
            //context.SetCurrentState(STA.Context.State3);    //设置状态机状态-State3
            //context.Handle1();  //执行State3状态下的各部逻辑
            //Console.WriteLine($"当前状态：{context}");
            //context.Handle2();
            //Console.WriteLine($"当前状态：{context}");
            //context.Handle3();
            //Console.WriteLine($"当前状态：{context}");
            #endregion

            #region 21.Interpreter Pattern 解释器模式 | 给定一门语言，定义它的文法的一种表示，并定义一个解释器，该解释器使用该表示来解释语言中的句子。
            //ITP.Context context;
            //string str;

            //str = "1 + 2 * (3 + 4) - 5";
            //context = new ITP.Context(str);
            //Console.WriteLine($"{str} = {context.Run()}");

            //str = "3 + 2 * (5 + 4)";
            //context = new ITP.Context(str);
            //Console.WriteLine($"{str} = {context.Run()}");

            //str = "6 + 4 / 2 * 9 - 4";                      
            //context = new ITP.Context(str);
            //Console.WriteLine($"{str} = {context.Run()}");

            //str = "(9 + 1) / 2 - 3 * (2 + 1)";
            //context = new ITP.Context(str);
            //Console.WriteLine($"{str} = {context.Run()}");

            //str = "3 - 4 * (7 - 7) + 1";
            //context = new ITP.Context(str);
            //Console.WriteLine($"{str} = {context.Run()}");
            #endregion

            #region 22.Flyweight Patter 享元模式 | 使用共享对象可有效地支持大量的细粒度的对象。
            //FLY.AbsFlyweight flyweight1 = FLY.FlyweightFactory.CreateFlyweight("A");
            //FLY.AbsFlyweight flyweight2 = FLY.FlyweightFactory.CreateFlyweight("A");
            //FLY.AbsFlyweight flyweight3 = FLY.FlyweightFactory.CreateFlyweight("B");
            //FLY.AbsFlyweight flyweight4 = FLY.FlyweightFactory.CreateFlyweight("B");

            //flyweight1.DoSomething("A1");
            //flyweight2.DoSomething("A2");
            //flyweight3.DoSomething("B1");
            //flyweight4.DoSomething("B2");

            //Console.WriteLine($"实际实例个数：{FLY.FlyweightFactory.InstanceCount}");
            #endregion

            #region 23.Bridge Pattern 桥梁模式 | 将抽象和实现解耦，使得两者可以独立的变化。
            //BRI.RefinedAbstraction refined = new BRI.RefinedAbstraction(new BRI.ConcreteImplementorA());    //实现化角色A
            //refined.Request();

            //refined = new BRI.RefinedAbstraction(new BRI.ConcreteImplementorB());   //实现化角色B
            //refined.Request();
            #endregion
        }
    }
}
