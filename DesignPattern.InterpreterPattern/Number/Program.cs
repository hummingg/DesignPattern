using System.Collections;

namespace DesignPattern.InterpreterPattern.Number
{
    class Program
    {
        public static void Show(string[] args)
        {
            string roman = "五千万亿七千三百零二万六千四百五十二";    // statement
            //分解：((五)亿) ((七千)(三百)(零)(二)万)
            //((六千)(四百)(五十)(二)个)

            //string roman = "七千万";
            //string roman = "五千万亿";

            Context context = new Context(roman);
            ArrayList tree = new ArrayList();

            tree.Add(new GeExpression());
            tree.Add(new ShiExpression());
            tree.Add(new BaiExpression());
            tree.Add(new QianExpression());
            tree.Add(new WanExpression());
            tree.Add(new YiExpression());

            // 个1-9，十1-9，百1-9，...
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.Write(context.Data);
        }
    }
}

// https://www.cnblogs.com/PatrickLiu/p/8242238.html