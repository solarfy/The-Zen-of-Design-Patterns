namespace ZenOfDesignPattern.Interpreter_Pattern
{
    //抽象表达式；解释器，具体的解释任务由各个实现类完成
    abstract class AbsExpression
    {
        //每个表达式必须有一个解析任务
        public abstract int Interpreter();
    }
}
