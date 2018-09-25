using System;

namespace 计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入运算符（+ - * / ）：");
                var operat = Console.ReadLine();
                var operation = OperationFactory.Create(operat);

                Console.Write("请输入NumberA：");
                operation.NumberA = double.Parse(Console.ReadLine());
                Console.Write("请输入NumberB：");
                operation.NumberB = double.Parse(Console.ReadLine());
                Console.WriteLine("结果：" + operation.GetResult());

                Console.WriteLine("按任意键进入下一次运算，按 q 退出。");
                var r = Console.ReadLine();
                if (r != null && r.Equals("q"))
                {
                    return;
                }
            }
        }
    }
}
