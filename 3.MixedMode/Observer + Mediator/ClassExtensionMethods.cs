namespace MixedMode.Observer_Mediator
{
    //扩展方法类
    static class ClassExtensionMethods
    {
        /// <summary>
        /// EventCustomerType；判断该类型中是否存在ProductEventType类型的枚举
        /// </summary>
        /// <param name="customType"></param>
        /// <param name="productType"></param>
        /// <returns></returns>
        public static bool Contains(this EventCustomerType customType, ProductEventType productType)
        {
            int value = 1 << ((int)productType);
            bool result = (value & (int)customType) != 0;
            return result;
        }           
    }
}
