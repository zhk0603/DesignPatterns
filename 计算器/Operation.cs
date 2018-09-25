using System;
using System.Collections.Generic;
using System.Text;

namespace 计算器
{
    public abstract class Operation 
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public abstract double GetResult();
    }

    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }

    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }

    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }

    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            return NumberA / NumberB;
        }
    }

    public sealed class OperationFactory
    {
        public static Operation Create(string operat)
        {
            Operation operation = null;
            switch (operat)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OperationSub();
                    break;
                case "*":
                    operation = new OperationMul();
                    break;
                case "/":
                    operation = new OperationDiv();
                    break;
                default:
                    throw new InvalidOperationException("指定操作符的运算没有实现，操作符：" + operat);
            }

            return operation;
        }
    }
}