namespace ZenOfDesignPattern.Interpreter_Pattern
{
    //终结符表达式；实现与文法中的元素相关联的解释操作，通常只有一个终结符表达式，但有多个实例
    //案例中为运算数字
    class ValueExpression : AbsExpression
    {
        private string strValue;

        public ValueExpression(string _strValue) => this.strValue = _strValue;

        public override int Interpreter()
        {
            return int.Parse(strValue);
        }
    }
}
