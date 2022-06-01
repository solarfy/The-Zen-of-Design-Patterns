using System;
using System.Collections.Generic;

namespace NewDesignPattern.Specification_Pattern
{
    //用户操作类
    class UserProvider : IUserProvider
    {
        private List<User> users;

        //通过构造函数传递用户列表
        public UserProvider(List<User> users)
        {
            this.users = users;
        }

        //根据指定的规格书查找用户
        public List<User> FindUser(ICompositeSpecification condition)
        {
            List<User> result = new List<User>() { };

            foreach (User u in users)
            {
                if (condition.IsSatisfiedBy(u))
                    result.Add(u);
            }

            //return new List<User>(new HashSet<User>(result));       //使用HashSet去重
            return result;
        }

        public static List<User> CreateUsers()
        {
            return new List<User>()
            {
                new User("苏大", 3),
                new User("牛二", 8),
                new User("张三", 10),
                new User("李四", 15),
                new User("王五", 18),
                new User("赵六", 20),
                new User("马七", 25),
                new User("杨八", 30),
                new User("侯九", 35),
                new User("布十", 40)
            };
        }

        public static void ShowUsers(List<User> users)
        {
            foreach (User u in users)
                Console.WriteLine(u);
        }
    }
}
