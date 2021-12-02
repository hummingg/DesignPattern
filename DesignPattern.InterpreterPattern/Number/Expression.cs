using System.Collections;

namespace DesignPattern.InterpreterPattern.Number
{
    // 抽象表达式
    public abstract class Expression
    {
        protected Dictionary<string, ulong> table = new Dictionary<string, ulong>(9);

        protected Expression()
        {
            table.Add("一", 1);
            table.Add("二", 2);
            table.Add("三", 3);
            table.Add("四", 4);
            table.Add("五", 5);
            table.Add("六", 6);
            table.Add("七", 7);
            table.Add("八", 8);
            table.Add("九", 9);
        }

        public abstract string GetPostFix();

        public abstract ulong Multiplier();

        // 个、万、亿、兆=亿亿 前面不一定是数字，返回 1
        // 十、百、千的翻译方法，前面一定是数字，返回 2
        public virtual int GetLength()
        {
            return this.GetPostFix().Length + 1;
        }

        // 个、万、亿、兆=亿亿 前面不一定是数字，有自己的翻译方法
        // 十、百、千的翻译方法，前面一定是数字
        public virtual void Interpret(Context context)
        {
            if (context.Statement.Length == 0)
            {
                return;
            }

            foreach (string key in table.Keys)
            {
                string postFix = this.GetPostFix();
                if (context.Statement.EndsWith(key + postFix)) // 一、一十、一百、一千...
                {
                    ulong value = table[key];
                    context.Data += value * this.Multiplier();
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - this.GetLength());
                }
                if (context.Statement.EndsWith("零"))    // 截2位后，末位可能是0
                {
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - 1);
                }
            }
        }
    }

    //个位表达式
    public sealed class GeExpression : Expression
    {
        public override string GetPostFix()
        {
            return "";
        }

        public override ulong Multiplier()
        {
            return 1;
        }

        public override int GetLength()
        {
            return 1;
        }
    }

    //十位表达式
    public sealed class ShiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "十";
        }

        public override ulong Multiplier()
        {
            return 10;
        }
    }

    //百位表达式
    public sealed class BaiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "百";
        }

        public override ulong Multiplier()
        {
            return 100;
        }
    }

    //千位表达式
    public sealed class QianExpression : Expression
    {
        public override string GetPostFix()
        {
            return "千";
        }

        public override ulong Multiplier()
        {
            return 1000;
        }
    }

    //万位表达式
    public sealed class WanExpression : Expression
    {
        public override string GetPostFix()
        {
            return "万";
        }

        public override ulong Multiplier()
        {
            return 10_000;
        }

        public override int GetLength()
        {
            return 1;
        }

        public override void Interpret(Context context)
        {
            if (context.Statement.Length == 0)
            {
                return;
            }

            ArrayList tree = new ArrayList();

            // 处理比自己小的单位
            tree.Add(new GeExpression());
            tree.Add(new ShiExpression());
            tree.Add(new BaiExpression());
            tree.Add(new QianExpression());

            foreach (string key in table.Keys)
            {
                string postFix = this.GetPostFix();
                if (context.Statement.EndsWith(postFix))
                {
                    ulong temp = context.Data;
                    context.Data = 0;

                    context.Statement = context.Statement.Substring(0, context.Statement.Length - this.GetLength());

                    foreach (Expression exp in tree)
                    {
                        exp.Interpret(context);
                    }
                    context.Data = temp + context.Data * this.Multiplier();
                }
            }
        }
    }

    //亿位表达式
    public sealed class YiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "亿";
        }

        public override ulong Multiplier()
        {
            return 100_000_000;
        }

        public override int GetLength()
        {
            return 1;
        }

        public override void Interpret(Context context)
        {
            ArrayList tree = new ArrayList();

            // 处理比自己小的单位
            tree.Add(new GeExpression());
            tree.Add(new ShiExpression());
            tree.Add(new BaiExpression());
            tree.Add(new QianExpression());
            tree.Add(new WanExpression());

            foreach (string key in table.Keys)
            {
                string postFix = this.GetPostFix();
                if (context.Statement.EndsWith(postFix))
                {
                    ulong temp = context.Data;
                    context.Data = 0;
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - this.GetLength());

                    foreach (Expression exp in tree)
                    {
                        exp.Interpret(context);
                    }
                    context.Data = temp + context.Data * this.Multiplier();
                }
            }
        }
    }
}