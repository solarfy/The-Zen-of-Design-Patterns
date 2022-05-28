using System;

namespace ZenOfDesignPattern.Interpreter_Pattern
{
    //非终结符表达式；每条规则对应一个非终结表达式
    //案例中为抽象的运算符
    class OperatorExpression : AbsExpression
    {
        //左右表达式（单个数字也为表达式）
        protected AbsExpression left;
        protected AbsExpression right;

        public OperatorExpression(AbsExpression _left, AbsExpression _right)
        {
            this.left = _left;
            this.right = _right;
        }

        public override int Interpreter()
        {
            throw new NotImplementedException();
        }
    }
}
