namespace DesignPattern.ProxyPattern
{
    /// <summary>
    /// 送礼物的人 （抽象主题角色）
    /// </summary>
    public abstract class GiftGiver
    {
        //送礼物功能
        public abstract void GiveGift();
    }

    /// <summary>
    /// 害羞男孩  （真实主题角色）
    /// </summary>
    public class ShyBoy : GiftGiver
    {
        public override void GiveGift()
        {
            Console.WriteLine("害羞男孩送礼物给如花~~");
        }
    }

    /// <summary>
    /// 害羞男孩请朋友帮忙送礼物（代理主题角色）
    /// </summary>
    public class Friend : GiftGiver
    {
        //引用真实主题实例
        ShyBoy shyboy = new ShyBoy();
        public override void GiveGift()
        {
            //朋友增加一顿分析后，觉得如花是个好人，不拦截
            bool IsRuhuaGood = true;
            if (IsRuhuaGood)
            {
                //调用真实主题的方法
                shyboy.GiveGift();
            }
        }
    }
}
