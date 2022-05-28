namespace DesignPatternPK.Strategy_VS_Bridge.Strategy
{
    //抽象邮件
    abstract class AbsMailTemplate
    {
        //邮件发件人
        private string from;

        public string From
        {
            get { return from; }
            set { from = value; }
        }

        //邮件接收人
        private string to;

        public string To
        {
            get { return to; }
            set { to = value; }
        }

        //邮件标题
        private string subject;
        
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        //邮件内容
        private string context;
        //用virtual表示子类可重写该属性
        public virtual string Context
        {
            get { return context; }
            set { context = value; }
        }

        public AbsMailTemplate(string _from, string _to, string _subject, string _context)
        {
            from = _from;
            to = _to;
            subject = _subject;
            context = _context;
        }

    }
}
