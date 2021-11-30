namespace DesignPattern.PrototypePattern
{
    /// <summary>
    /// 人类原型抽象类
    /// 相当于 ICloneable 接口类
    /// </summary>
    public abstract class PersonPrototype
    {
        public abstract object Clone();
    }
}