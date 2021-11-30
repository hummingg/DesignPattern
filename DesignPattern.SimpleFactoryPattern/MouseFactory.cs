using System.Configuration;

namespace DesignPattern.SimpleFactoryPattern
{
    /// <summary>
    /// 鼠标工厂类
    /// </summary>
    public class MouseFactory
    {
        //从配置文件中读取品牌
        private static readonly string brand = ConfigurationManager.AppSettings["BrandOfMouse"];
        private Mouse mouse = null;
        public Mouse CreateMouse(string customBrand="")
        {
            string finalBrand = string.IsNullOrWhiteSpace(customBrand) ? brand : customBrand;
            switch (finalBrand)
            {
                case "dell":
                    mouse = new DellMouse();
                    break;
                case "hp":
                    mouse = new HpMouse();
                    break;
                default:
                    break;
            }
            return mouse;
        }
    }
}
