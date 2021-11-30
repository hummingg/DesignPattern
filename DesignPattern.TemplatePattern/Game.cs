using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplatePattern
{
    /// <summary>
    /// 抽象游戏类
    /// </summary>
    public abstract class Game
    {
        //每款游戏都要投币，子类不能重写
        public void InsertCoins()
        {
            Console.WriteLine("往游戏机里投币...");
        }
        public abstract void InitGame();
        public abstract void StartGame();
        public abstract void EndGame();

        //Play是模板方法，定义了子类执行的步骤
        public void Play()
        {
            //投币
            InsertCoins();
            //初始化游戏
            InitGame();
            //游戏开始
            StartGame();
            //游戏结束
            EndGame();
        }
    }

    /// <summary>
    /// 恐龙快打游戏
    /// </summary>
    public class KLKDGame : Game
    {
        public override void InitGame()
        {
            Console.WriteLine("初始化恐龙快打游戏..");
        }

        public override void StartGame()
        {
            Console.WriteLine("开始玩恐龙快打游戏..");
        }
        public override void EndGame()
        {
            Console.WriteLine("恐龙快打游戏结束！");
        }
    }

    /// <summary>
    /// 三国无双游戏
    /// </summary>
    public class SGWSGame : Game
    {
        public override void InitGame()
        {
            Console.WriteLine("初始化三国无双..");
        }

        public override void StartGame()
        {
            Console.WriteLine("开始玩三国无双..");
        }
        public override void EndGame()
        {
            Console.WriteLine("三国无双游戏结束！");
        }
    }
}
