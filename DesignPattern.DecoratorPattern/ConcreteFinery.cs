namespace DesignPattern.DecoratorPattern
{
    //t恤
    public class TShirt : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.Write("大t恤  ");
        }
    }
    //网鞋
    public class Sneaker : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.Write("网鞋  ");
        }

    }
    //西装
    public class Suit : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.Write("西装  ");
        }
    }
    //领带
    public class Tie : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.Write("领带  ");
        }
    }
    //皮鞋
    public class Leather : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.Write("皮鞋  ");
        }
    }
}
