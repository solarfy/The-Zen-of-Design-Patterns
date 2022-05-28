using System;

namespace ZenOfDesignPattern.Interpreter_Pattern
{
    //除法运算符
    class VarDivExp : OperatorExpression
    {
        public VarDivExp(AbsExpression left, AbsExpression right) : base(left, right)
        {

        }

        public override int Interpreter()
        {
            int rightNumber = base.right.Interpreter();

            if (0 == rightNumber)
                throw new Exception("无效的表达式：0不能被整除");

            return base.left.Interpreter() / rightNumber;
        }
    }
}
