using System;

using FMB_FM        = DesignPatternPK.FacotryMethod_VS_Builder.FactoryMethod;
using FMB_B         = DesignPatternPK.FacotryMethod_VS_Builder.Builder;

using AFB_AF        = DesignPatternPK.AbstractFactory_VS_Builder.AbstractFactory;
using AFB_B         = DesignPatternPK.AbstractFactory_VS_Builder.Builder;

using PD            = DesignPatternPK.Prox_VS_Decorator;

using DA_D          = DesignPatternPK.Decorator_VS_Adapter.Decorator;
using DA_A          = DesignPatternPK.Decorator_VS_Adapter.Adapter;

using CS_S          = DesignPatternPK.Cmd_VS_Strategy.Strategy;
using CS_C          = DesignPatternPK.Cmd_VS_Strategy.Cmd;

using ST_S          = DesignPatternPK.Strategy_VS_State.Strategy;
using ST_T          = DesignPatternPK.Strategy_VS_State.State;

using OR_R          = DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Responsibility;
using OR_O          = DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Observer;

using SB_S          = DesignPatternPK.Strategy_VS_Bridge.Strategy;
using SB_B          = DesignPatternPK.Strategy_VS_Bridge.Bridge;

using MF_M          = DesignPatternPK.Mediator_VS_Facade.Mediator;
using MF_F          = DesignPatternPK.Mediator_VS_Facade.Facade;

using PMG_A         = DesignPatternPK.Packaging_mode_group.Agent;
using PMG_D         = DesignPatternPK.Packaging_mode_group.Decorator;
using PMG_AD        = DesignPatternPK.Packaging_mode_group.Adapter;
using PMG_B         = DesignPatternPK.Packaging_mode_group.Bridge;

namespace DesignPatternPK
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 创建类模式 | 工厂方法模式VS建造者模式
            /* 工厂方法模式：关注的是一个产品的整体，无须关心产品的各部分。
             * 建造者模式：一个具体产品的产生是依赖各个部件的产生以及装配顺序，“零件一步一步地组装出产品的对象”             
             */
            //Console.WriteLine("工厂方法模式↓↓↓");
            //FMB_FM.ISuperMan adultSuperMan = FMB_FM.SuperManFactory.CreateSuperMan<FMB_FM.AdultSuperMan>();    
            //adultSuperMan.SpecialTalent();

            //Console.WriteLine("建造者模式↓↓↓");
            //FMB_B.SuperMan superMan = FMB_B.Director.CreateAdultSuperMan();     
            //superMan.Show();
            #endregion

            #region 创建类模式 | 抽象工厂模式VS建造者模式
            /* 抽象工厂模式：使用“工厂”来描述构建者，它关注的是生产什么产品。 
             * 建造者模式：使用“车间”来描述构建者，他关注的是生产的过程。             
             */
            //Console.WriteLine("抽象工厂模式↓↓↓");
            //AFB_AF.ICar car1 = new AFB_AF.BMWFactory().CreateSuv();     
            //AFB_AF.ICar car2 = new AFB_AF.BenzFactory().CreateVan();
            //car1.Run();
            //car2.Run();

            //Console.WriteLine("建造者模式↓↓↓");
            //AFB_B.ICar car3 = new AFB_B.Director().CreateComplexBenzCar();  
            //AFB_B.ICar car4 = new AFB_B.Director().CreateComplexBmwCar();
            //car3.Run();
            //car4.Run();
            #endregion

            #region 结构类模式 | 代理模式VS装饰模式
            /* 代理模式：把当前的行为或功能委托给其他对象的执行，代理类负责接口的限定。
             * 装饰模式：保证接口不变的情况下加强类的功能。
             */
            //PD.IRunner runner = new PD.Runner();    //实际运动员
            //runner = new PD.RunnerDecorator(runner);    //装饰实际运动员
            //PD.IRunner agent = new PD.RunnerAgent(runner);  //代理者
            //agent.Run();
            #endregion

            #region 结构类模式 | 装饰模式VS适配器模式
            /* 装饰模式：加强或减小对象的功能；装饰的对象必须是自己的同宗，也就是相同的接口或父类。
             * 适配器模式：修饰非血缘关系类，把一个非本家族的对象伪装成本家族的对象。
             */
            //Console.WriteLine("装饰器模式↓↓↓");
            //DA_D.ISwan duckling = new DA_D.UglyDuckling();    
            //Console.WriteLine("小时候的丑小鸭");
            //duckling.Appaearance();
            //duckling.Cry();
            //duckling.Fly();

            //duckling = new DA_D.BeautifulAppearance(duckling);
            //duckling = new DA_D.FlyBehavior(duckling);
            //Console.WriteLine("长大后的丑小鸭");
            //duckling.Appaearance();
            //duckling.Cry();
            //duckling.Fly();

            //Console.WriteLine("适配器模式↓↓↓");
            //DA_A.IDuck duck = new DA_A.Duckling();    
            //Console.WriteLine("普通的鸭子");
            //duck.Appearance();
            //duck.Cry();
            //duck.Behavior();

            //duck = new DA_A.UglyDuckling();
            //Console.WriteLine("丑小鸭");
            //duck.Appearance();
            //duck.Cry();
            //duck.Behavior();
            #endregion

            #region 行为类模式 | 命令模式VS策略模式
            /* 策略模式：算法的替换，新算法替换旧算法，或者多种算法并存，由调用者自己选择使用。
             * 命令模式：解耦，请求者和执行者进行解耦，将请求的内容封装成命令，由接收者执行。可对命令进行多种处理，例如撤销、记录等。
             */
            //Console.WriteLine("策略模式↓↓↓");
            //CS_S.Context context;  
            //context = new CS_S.Context(new CS_S.Gzip());    //执行Gzip策略
            //context.Compress("file.txt", "file.gzip");
            //context.Uncompress("file.gzip", "file.txt");
            //context = new CS_S.Context(new CS_S.Zip());     //将策略替换为Zip
            //context.Compress("file.txt", "file.zip");
            //context.Uncompress("file.zip", "file.txt");

            //Console.WriteLine("命令模式↓↓↓");
            //CS_C.Invoker invoker;
            //invoker = new CS_C.Invoker(new CS_C.ZipComressCmd());
            //invoker.Execute("file.txt", "file.zip");            //执行Zip压缩命令
            //invoker = new CS_C.Invoker(new CS_C.GzipUncompressCmd());
            //invoker.Execute("file.gzip", "file.text");          //执行Gzip解压缩命令
            #endregion

            #region 行为类模式 | 策略模式VS状态模式
            /* 策略模式：算法的封装，保证算法可以自由替换。
             * 状态模式：旨在解决内在状态的改变而引起行为改变的问题，出发点是事务的状态
             */
            //Console.WriteLine("策略模式↓↓↓");
            //ST_S.Context context = new();
            //context.SetWork(new ST_S.ChildWork());
            //context.Work();
            //context.SetWork(new ST_S.AdultWork());
            //context.Work();
            //context.SetWork(new ST_S.OldWork());
            //context.Work();

            //Console.WriteLine("状态模式↓↓↓");
            //ST_T.Human human = new();
            //human.SetState(ST_T.Human.CHILD_STATE);
            //human.Work();
            //human.Work();
            //human.Work();
            #endregion

            #region 行为类模式 | 责任链模式VS观察者模式（触发链）
            /* 责任链模式：不改变消息对象的结构；上下级节点无任何关系，都是接收相同的对象；消息传播单一，固定；
             * 观察者模式（触发链）：消息对象可自由的改变，只要上下级间对传递对象了解即可；上下级间关系亲密；消息传播不固定，可以广播也可以跳跃。
             */
            //Console.WriteLine("责任链模式↓↓↓");
            //OR_R.SHDnsServer sh = new();   //上海域名服务器
            //OR_R.ChinaTopDnsServer chian = new();   //中国顶级域名服务器
            //OR_R.TopDnsServer top = new();  //全球顶级服务器

            //sh.SetUpperServer(chian);   //责任链：上海 --> 中国 --> 全球
            //chian.SetUpperServer(top);

            //foreach (string str in OR_R.Tools.CreateDomains())
            //{
            //    OR_R.Recorder recorder = sh.Resolve(str);   //从链头开始
            //    Console.WriteLine("-----DNS服务器解析结果-----");
            //    Console.WriteLine(recorder);
            //}

            //Console.WriteLine("观察者模式（触发链）↓↓↓");
            //OR_O.SHDnsServer osh = new();   //上海域名服务器
            //OR_O.ChinaTopDnsServer ochian = new();   //中国顶级域名服务器
            //OR_O.TopDnsServer otop = new();  //全球顶级服务器

            //osh.Subscribe(ochian);   //观察顺序：上海 --> 中国 --> 全球
            //ochian.Subscribe(otop);

            //foreach (OR_R.Recorder r in OR_R.Tools.CreateRecorders())
            //{
            //    osh.OnNext(r);      //从第一个被观察者开始
            //    Console.WriteLine("-----DNS服务器解析结果-----");
            //    Console.WriteLine(r);   
            //    //所有的结果均显示“上海DNS服务器”，这是正确的；所有的节点只需知道是由父节点解析的，而不需要知道父节点请求了更上层的节点，只要是上级的结果就是上级的。
            //}

            #endregion

            #region 跨区PK | 策略模式VS桥梁模式
            /* 策略模式：行为模式，旨在封装一系列的行为（算法）；通过继承和多态建立一套可以自由切换算法的模式。
             * 桥梁模式：结构模式，在不破换封装的情况下抽取出抽象部分和实现部分；桥梁模式必然有两个”桥墩“--抽象化角色和实现化角色。
             */
            //Console.WriteLine("策略模式↓↓↓");
            //SB_S.MailServer server = new();
            //server.SendMail(new SB_S.TextMail("a.com", "b.com", "你好", "认识你很高兴"));
            //server.SendMail(new SB_S.HtmlMail("b.com", "a.com", "O(∩_∩)O", "我也一样"));

            //Console.WriteLine("桥梁模式↓↓↓");
            //SB_B.AbsMailServer postfix = new SB_B.Postfix();
            //postfix.SendMail(new SB_B.TextMail("a.com", "b.com", "你好", "认识你很高兴"));
            //SB_B.AbsMailServer winmail = new SB_B.Winmail();
            //winmail.SendMail(new SB_B.HtmlMail("b.com", "a.com", "O(∩_∩)O", "我也一样"));
            #endregion

            #region 跨区PK | 中介者模式VS门面模式
            /* 中介者模式：以调和同事类之间的关系为主，所以有部分的业务逻辑控制。
             *             每个同事类需知道中介者的存在。
             * 门面模式：封装和隔离为主要任务，不处理任何逻辑，对子系统无任何影响，子系统脱离门面后仍可独立允许。
             *           子系统不需要知道门面的存在。
             */
            //Console.WriteLine("中介者模式↓↓↓");
            //MF_M.Mediator mediator = new();     //中介者
            //MF_M.Position position = new(mediator);     //各个同事类
            //MF_M.Salary salary = new(mediator);
            //MF_M.Tax tax = new(mediator);

            //Console.WriteLine("职位上升：");
            //position.Promote();
            //Console.WriteLine("税率下降：");
            //tax.Drop();
            //Console.WriteLine("工资增加：");
            //salary.IncreaseSalary();

            //Console.WriteLine("门面模式↓↓↓");
            //MF_F.HRFacade hR = new();   //定义门面
            //Console.WriteLine($"张三这个月的收入为：{hR.QuerySalary("张三", DateTime.Now)}");
            //Console.WriteLine($"张三这个月的考勤天数为：{hR.QueryWorkDays("张三", DateTime.Now)}");            
            #endregion

            #region 跨区PK | 包装模式群PK
            /* 代理模式：主要用在不希望展示一个对象内部细节的场景中；通过代理类，可轻松实现被代理类的功能的封装。
             * 装饰模式：特殊的代理模式，它提倡在不改变接口的前提下为对象增强功能。
             * 适配器模式：主要意图是接口的转换，把一个对象的接口转换成系统希望的另一个接口。
             * 桥梁模式：在抽象层产生耦合，使两个有耦合关系的对象互不影响地扩展。
             * 门面模式：一个粗粒度的封装，它提供一个方便访问子系统的接口，不具有任何的业务逻辑，没有它，子系统照样运行。
             */ 
            //Console.WriteLine("代理模式↓↓↓");
            //PMG_A.IStar star = new PMG_A.Singer();  //明星
            //PMG_A.IStar agent = new PMG_A.Agent(star);  //star的经纪人
            //agent.Sign();       //找到明星代理，由明星签字

            //Console.WriteLine("装饰器模式↓↓↓");
            //PMG_D.IStar freakStar = new PMG_D.FreakStar();   //定义一个假名星
            //freakStar = new PMG_D.HotAir(freakStar);    //HotAir装饰
            //freakStar = new PMG_D.Deny(freakStar);      //Deny装饰
            //freakStar.Act();

            //Console.WriteLine("适配器模式↓↓↓");
            //PMG_AD.Direcotr direcotr = new();       //定义一个导演
            //direcotr.Play();    

            //Console.WriteLine("模式↓↓↓");
            //PMG_B.AbsStar fs = new PMG_B.FilmStar();    //定义一个电影明星
            //fs.DoJob();
            //PMG_B.AbsStar si = new PMG_B.Singer();      //定义一个歌手
            //si.DoJob();

            //fs = new PMG_B.FilmStar(new PMG_B.Sing());  //电影明星也可以唱歌
            //fs.DoJob();
            //si = new PMG_B.Singer(new PMG_B.ActFilm()); //歌手也可以演电影
            //si.DoJob();
            #endregion
        }
    }
}
