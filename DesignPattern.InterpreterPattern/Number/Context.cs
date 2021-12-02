namespace DesignPattern.InterpreterPattern.Number
{
    //环境上下文
    public sealed class Context
    {
        private string _statement;  // 剩余待处理中文串
        private ulong _data;    // 中间数字

        public Context(string statement)
        {
            this._statement = statement;
        }

        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        public ulong Data
        {
            get { return this._data; }
            set { this._data = value; }
        }
    }
}
