namespace NewDesignPattern.Specification_Pattern
{
    //名字相同的规格书
    class UserByNameEqual : CompositeSpecification
    {
        //基准名字
        private string name;

        public UserByNameEqual(string name)
        {
            this.name = name;
        }

        public override bool IsSatisfiedBy(User user)
        {
            return user.Name == name;
        }
    }

    //大于基准年龄的规格书
    class UserByAgeThan : CompositeSpecification
    {
        //基准年龄
        private int age;

        public UserByAgeThan(int age)
        {
            this.age = age;
        }

        public override bool IsSatisfiedBy(User user)
        {
            return user.Age > age;
        }
    }

    //Like规格书
    class UserByNameLike : CompositeSpecification
    {
        //Like标记
        private const string LIKE_FLAG = "%";

        private string[] likeStrs;

        public UserByNameLike(string[] likeStrs)
        {
            this.likeStrs = likeStrs;
        }

        public override bool IsSatisfiedBy(User user)
        {
            bool result = false;
            string name = user.Name;
        
            for (int i = 0; i < likeStrs.Length; i++)
            {
                string like = likeStrs[i].Replace(LIKE_FLAG, string.Empty);
                if (name.Contains(like))
                {
                    result = true;
                    break;
                }
            }

            return result;            
        }
    }
}
