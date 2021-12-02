using System.Text;

namespace DesignPattern.BuilderPattern
{
    //建造者抽象类，定义了建造者的能力
    public abstract class Builder
    {
        public abstract void Dadiji();//打地基
        public abstract void QiZhuan();//砌砖
        public abstract void FenShua();//粉刷
    }

    /// <summary>
    /// 技术好的建造者
    /// </summary>
    public class GoodBuilder : Builder
    {
        private StringBuilder house = new StringBuilder();
        public override void Dadiji()
        {
            house.Append("挖深地基-->");
            //这里一般是new一个部件，添加到实例中，如 house.Diji=new Diji("深地基")
            //为了演示方便 用sringBuilder表示一个复杂的房子，string表示房子的部件
        }

        public override void FenShua()
        {
            house.Append("粉刷光滑-->");
        }

        public override void QiZhuan()
        {
            house.Append("砌砖整齐-->");
        }

        public string GetHouse()
        {
            return house.Append("好质量房子建成了！").ToString();
        }
    }

    /// <summary>
    /// 技术差的建造者
    /// </summary>
    public class BadBuilder : Builder
    {
        private StringBuilder house = new StringBuilder();
        public override void Dadiji()
        {
            house.Append("挖浅地基-->");
        }

        public override void FenShua()
        {
            house.Append("粉刷粗糙-->");
        }

        public override void QiZhuan()
        {
            house.Append("砌砖错乱-->");
        }

        public string GetHouse()
        {
            return house.Append("坏质量房子建成了！").ToString();
        }
    }
}
