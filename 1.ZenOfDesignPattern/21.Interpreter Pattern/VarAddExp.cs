namespace ZenOfDesignPattern.Interpreter_Pattern
{
    //加法运算符
    class VarAddExp : OperatorExpression
    {
        public VarAddExp(AbsExpression left, AbsExpression right) : base(left, right)
        {           

        }

        public override int Interpreter()
        {
            return base.left.Interpreter() + base.right.Interpreter();            
        }
    }
}
