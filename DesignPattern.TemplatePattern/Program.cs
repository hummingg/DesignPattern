namespace DesignPattern.TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //玩恐龙快打
            Game klkdGame = new KLKDGame();
            klkdGame.Play();

            //玩三国无双
            Game sgwsGame = new SGWSGame();
            sgwsGame.Play();
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/10049734.html