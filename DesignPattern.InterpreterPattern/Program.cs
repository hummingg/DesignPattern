using System.Text;

namespace DesignPattern.InterpreterPattern
{
    //1.抽象表达式
    //抽象解释接口
    public interface IExpression
    {
        void Interpret(StringBuilder sb);
    }

    //2.非终结符表达式
    //单词解释（非终结符解释）
    public class WordExpression : IExpression
    {
        private string _value;

        public WordExpression(string value)
        {
            _value = value;
        }

        public void Interpret(StringBuilder sb)
        {
            sb.Append(ChineseEnglishDict.GetEnglish(_value.ToLower()));
        }
    }

    //3.终结符表达式
    //标点符号解释（终结符解释）
    public class SymbolExpression : IExpression
    {
        private string _value;

        public SymbolExpression(string value)
        {
            _value = value;
        }

        public void Interpret(StringBuilder sb)
        {
            switch (_value)
            {
                case ".":
                    sb.Append("。");
                    break;
            }
        }
    }

    //4.环境类Context
    //容器（保存解释器中所对应的具体值）
    public static class ChineseEnglishDict
    {
        private static Dictionary<string, string> _dictory = new Dictionary<string, string>();

        static ChineseEnglishDict()
        {
            _dictory.Add("this", "这");
            _dictory.Add("is", "是");
            _dictory.Add("an", "一个");
            _dictory.Add("apple", "苹果");
            _dictory.Add("orange", "橘子");
        }

        public static string GetEnglish(string value)
        {
            return _dictory[value];
        }
    }

    class Program
    {
        //调用
        public static void Main(string[] args)
        {
            string englist = "This is an apple.This is an orange.";
            StringBuilder sb = new StringBuilder();
            List<IExpression> expressions = new List<IExpression>();
            string[] sentences = englist.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    expressions.Add(new WordExpression(word));
                }
                expressions.Add(new SymbolExpression("."));
            }
            foreach (IExpression expression in expressions)
            {
                expression.Interpret(sb);
            }
            Console.WriteLine(sb.ToString());

            DesignPattern.InterpreterPattern.Number.Program.Show(new string[] { });
        }
    }
}