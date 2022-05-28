namespace ZenOfDesignPattern.Interpreter_Pattern
{
    //加法运算符
    class VarSubExp : OperatorExpression
    {
        public VarSubExp(AbsExpression left, AbsExpression right) : base(left, right)
        {

        }

        public override int Interpreter()
        {
            return base.left.Interpreter() - base.right.Interpreter();
        }
    }
}
