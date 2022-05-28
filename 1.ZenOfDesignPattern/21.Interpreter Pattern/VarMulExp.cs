namespace ZenOfDesignPattern.Interpreter_Pattern
{
    //乘法运算符
    class VarMulExp : OperatorExpression
    {
        public VarMulExp(AbsExpression left, AbsExpression right) : base(left, right)
        {

        }

        public override int Interpreter()
        {
            return base.left.Interpreter() * base.right.Interpreter();
        }
    }
}
