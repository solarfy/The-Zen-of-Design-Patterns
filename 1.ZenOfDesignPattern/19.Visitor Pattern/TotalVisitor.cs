using System;
using System.Text;

namespace ZenOfDesignPattern.Visitor_Pattern
{
    //实际的汇总访问者
    class TotalVisitor : ITotalVisitor
    {
        private StringBuilder context = new();

        private int total = 0;

        public void TotalNumber()
        {
            string text = context.ToString();
            text = text[0..^3];  //同text.Substring(0, text.Length - 3)  范围运算符[startIndex..endIndex]  ^操作符表示从数组末尾计算索引

            Console.WriteLine($"合计: {text} = {total}");
        }

        public void Visit(ConcreteElementA elementA)
        {
            total += elementA.Number;
            context.Append($"{elementA.Number} + ");
        }

        public void Visit(ConcreteElementB elementB)
        {
            total += elementB.Number * 10;
            context.Append($"{elementB.Number} * 10 + ");
        }

        public void Visit(ConcreteElementC elementC)
        {
            total += elementC.Number * 100;
            context.Append($"{elementC.Number} * 100 + ");
        }
    }
}
