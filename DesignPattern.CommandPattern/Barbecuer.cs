namespace DesignPattern.CommandPattern
{
    public class Barbecuer
    {
        public int cntMutton = 0;   // 业绩
        public int cntChicken = 0;

        //烤羊肉串
        public void BakeMutton()
        {
            cntMutton++;
            Console.WriteLine($"{cntMutton}：烤羊肉串，贵但好吃！");
        }

        //烤鸡
        public void BakeChicken()
        {
            cntChicken++;
            Console.WriteLine($"{cntChicken}：烤鸡，好吃不贵！");
        }
    }
}
