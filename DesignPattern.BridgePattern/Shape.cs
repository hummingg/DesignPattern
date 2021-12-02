namespace DesignPattern.BridgePattern
{
    public abstract class Shape
    {
        //形状内部包含了另一个维度：color
        protected IColor color;
        public void SetColor(IColor color)
        {
            this.color = color;
        }
        //设置形状
        public abstract void Draw();
    }

    /// <summary>
    /// 圆形
    /// </summary>
    public class Circle : Shape
    {
        public override void Draw()
        {
            color.Paint("圆形");
        }
    }
    /// <summary>
    /// 长方形
    /// </summary>
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            color.Paint("长方形");
        }
    }
    /// <summary>
    /// 三角形
    /// </summary>
    public class Triangle : Shape
    {
        public override void Draw()
        {
            color.Paint("三角形");
        }
    }
}
