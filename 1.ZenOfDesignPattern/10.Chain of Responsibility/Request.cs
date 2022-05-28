namespace ZenOfDesignPattern.Chain_of_Responsibility
{
    public class Request
    {
        //事件等级
        public Levels Level { get; private set; }
        //请求内容
        public string Content { get; private set; }

        public Request(Levels level, string content)
        {
            this.Level = level;
            this.Content = content;
        }
    }
}
