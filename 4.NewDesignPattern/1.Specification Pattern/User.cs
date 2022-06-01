namespace NewDesignPattern.Specification_Pattern
{
    class User
    {
        //姓名
        public string Name { get; set; }
        //年龄
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"用户名：{Name}\t年龄：{Age}";
        }
    }
}
