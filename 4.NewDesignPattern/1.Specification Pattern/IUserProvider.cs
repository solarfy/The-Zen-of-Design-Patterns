using System.Collections.Generic;

namespace NewDesignPattern.Specification_Pattern
{
    //用户操作接口
    interface IUserProvider
    {
        //根据条件查找用户
        List<User> FindUser(ICompositeSpecification condition);
    }
}
