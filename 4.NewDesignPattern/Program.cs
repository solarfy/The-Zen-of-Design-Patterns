using System;
using SP = NewDesignPattern.Specification_Pattern;
using OPP = NewDesignPattern.Object_Pool_Pattern;
using HHP = NewDesignPattern.Hire_Hand_Pattern;
using NOP = NewDesignPattern.Null_Object_Pattern;

namespace NewDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 规格模式 | 整体和部分的关系，属于组合模式的扩展。
            //var users = SP.UserProvider.CreateUsers();      //初始化一组用户
            //SP.IUserProvider userProvider = new SP.UserProvider(users);  //用户查询
            //SP.ICompositeSpecification condition1 = new SP.UserByAgeThan(20);    //查找年龄超过20的用户              
            //SP.ICompositeSpecification condition2 = new SP.UserByNameLike(new string[] { "%六%", "三", "%十" });    //查找类似名字
            //users = userProvider.FindUser(condition2.OR(condition1));       //查找类似名字或年龄超过20的用户
            //SP.UserProvider.ShowUsers(users);
            #endregion

            #region 对象池模式 | 一次性的初始化所有对象，减少对象在初始化上的性能开销，从而提高系统整体性能。
            //OPP.ProductPool productPool = new();
            //OPP.Product product = productPool.CreateObject();       //创建一个产品
            //Console.WriteLine($"产品信息：{product}");
            //productPool.ReleaseObject(product);        //回收一个产品
            #endregion

            #region 雇工模式 | 行为模式的一种，为一组类提供通用的功能，而不需要类实现这些功能，它属于命令模式的扩展。
            //HHP.Servant servant = new();    //定义一个雇工
            //servant.Work(new HHP.Garden());     //雇工在花园工作--打扫了花园
            //servant.Work(new HHP.Kitchen());    //雇工在厨房工作--打扫了厨房
            //servant.Work(new HHP.Cloth());      //雇工--洗衣服
            #endregion

            #region 空对象模式 
            //NOP.IAnimal animal = new NOP.NullAnimal();      //定义的时候使用空对象
            ////if (animal != null)    //不再需要此处判断
                //animal.MakeSound();

            #endregion

            #region 黑板模式 | 观察者模式的扩展，允许多个消息的读写同时存在，消息的生产者和消费者完全分开。
            /* 参照消息队列，既可以做到消息的同步处理，也可以实现异步处理
             */ 
            #endregion


        }
    }
}
