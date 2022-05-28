/*
 *
    逆波兰算法的核心步骤就2个：
    1、将中缀表达式转换为后缀表达式，例如输入的原始表达式是 3*（5+7） ，转换得到 3 5 7 + *
    2、根据后缀表达式，按照特定的计算规则得到最终计算结果

    中缀表达式转换为后缀表达式：
    1、你需要设定一个栈SOP,和一个线性表 L 。SOP用于临时存储运算符和左括号分界符( ，L用于存储后缀表达式。
    2、遍历原始表达式中的每一个表达式元素：
    （1）如果是操作数，则直接追加到 L中。只有 运算符 或者 分界符（ 才可以存放到 栈SOP中
    （2）如果是分界符
    Ⅰ 如果是左括号 ( ， 则 直接压入SOP，等待下一个最近的 右括号 与之配对。
    Ⅱ 如果是右括号 ) ，则说明有一对括号已经配对(在表达式输入无误的情况下)。
    不将它压栈，丢弃它，然后从SOP中出栈，得到元素e，将e依次追加到L里。一直循环，直到出栈元素e 是 左括号 ( ，同样丢弃他。
    （3）如果是运算符（用op1表示）
    Ⅰ 如果SOP栈顶元素（用op2表示） 不是运算符，则二者没有可比性，则直接将此运算符op1压栈。 例如栈顶是左括号 ( ，或者栈为空。
    Ⅱ 如果SOP栈顶元素（用op2表示） 是运算符 ，则比较op1和 op2的优先级。如果op1 > op2 ，则直接将此运算符op1压栈。
    如果不满足op1 > op2，则将op2出栈，并追加到L，再试图将op1压栈，如果如果依然不满足 op1>新的栈顶op2，继续将新的op2弹出追加到L ，直到op1可以压入栈中为止。
    也就是说，如果在SOP栈中，有2个相邻的元素都是运算符，则他们必须满足：下层运算符的优先级一定小于上层元素的优先级，才能相邻。
    3、最后，如果SOP中还有元素，则依次弹出追加到L后，就得到了后缀表达式。

    逆波兰式的计算：
    1、从左到右扫描表达式，如果当前字符为数字，则入栈。
    2、如果当前字符为运算符，则将栈顶两个元素出栈，作相应运算，结果再入栈。
    3、最后当表达式扫描完后，栈里的就是计算结果了。
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZenOfDesignPattern.Interpreter_Pattern
{
    class Context
    {
        private string expStr;

        public Context(string _expStr)
        {
            this.expStr = _expStr;            
        }

        //使用逆波兰方式运算表达式
        public int Run()
        {
            InversePoland(expStr.Replace(" ", ""), out Stack<string> stack);

            //表达式链
            AbsExpression expression = null;
            //表达式集合
            Stack<AbsExpression> sop = new();
            
            foreach (string str in stack.ToList().Reverse<string>())
            {
                //Console.WriteLine(str);
                if (IsNumber(str))                
                    sop.Push(new ValueExpression(str));
                else
                {                                    
                    expression = CreateExpression(str, sop.Pop(), sop.Pop());   //注：优先出栈的为右操作数
                    sop.Push(expression);  //将单步运算结果再压入栈
                    //Console.WriteLine($"单步结果：{expression.Interpreter()}");
                }
            }
            
            return expression.Interpreter();    //Interpreter()；递归
        }

        private bool IsNumber(string c) => int.TryParse(c, out _);

        //逆波兰表达式
        private void InversePoland(string expStr, out Stack<string> stack)
        {
            stack = new();  //数字放入底部，符号放入上部 
            Stack<string> symbol = new();   //放入符号，非括号内优先级低的沉底
            Stack<string> tmp = new();
            StringBuilder number = new();

            for (int i = 0; i < expStr.Length; i++)
            {               
                char c = expStr[i];

                //取出相邻的数字
                for (; i < expStr.Length && IsNumber((c = expStr[i]).ToString()); i++)
                {
                    number.Append(c);
                }

                //填充数字
                if (number.Length > 0)
                {
                    stack.Push(number.ToString());
                    number.Clear();
                    i--;    //取数字时索引i已向后移动一位，此处将索引i重置一位，并跳入至主循环重新判断。
                    continue;
                }
                
                //符号
                switch (c)
                {                                           
                    case '+':   //低优先级的需将其它同层的运算符都取出，再将自身压入符号栈
                    case '-':
                        while ((symbol.Count > 0) && (symbol.Peek() == "*" || symbol.Peek() == "/" || symbol.Peek() == "+" || symbol.Peek() == "-"))
                        {
                            stack.Push(symbol.Pop());
                        }
                        symbol.Push(c.ToString());
                        break;

                    case '*':   //高优先级的直接入栈，同级别的需先将其取出再入栈
                    case '/':
                        while ((symbol.Count > 0) && (symbol.Peek() == "*" || symbol.Peek() == "/"))
                        {
                            stack.Push(symbol.Pop());
                        }
                        symbol.Push(c.ToString());
                        break;

                    case '(':
                        symbol.Push(c.ToString());
                        break;

                    case ')':
                        //取出左右括号中的符号，并舍弃左右两个括号
                        while (symbol.Count > 0)
                        {
                            if (symbol.Peek() != "(")
                                stack.Push(symbol.Pop());
                            else
                            {
                                symbol.Pop();   //丢弃左括号
                                break;
                            }
                        }
                        break;

                    default:
                        throw new Exception("无效的表达式");
                }               
            }           

            //按栈顺序将符号集填入主容器
            while (symbol.Count > 0)
            {                          
                stack.Push(symbol.Pop());
            }
        }

        //生成运算表达式
        private AbsExpression CreateExpression(string symbol, AbsExpression right, AbsExpression left)
        {
            AbsExpression expression = null;

            switch (symbol)
            {
                case "+":
                    expression = new VarAddExp(left, right);
                    break;

                case "-":
                    expression = new VarSubExp(left, right);
                    break;

                case "*":
                    expression = new VarMulExp(left, right);
                    break;

                case "/":
                    expression = new VarDivExp(left, right);
                    break;

                default:
                    break;
            }

            return expression;
        }

    }
}
