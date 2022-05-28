namespace DesignPatternPK.Strategy_VS_Bridge.Bridge
{
    //文本邮件
    class TextMail : AbsMailTemplate
    {
        public TextMail(string _from, string _to, string _subject, string _context) : base(_from, _to, _subject, _context)
        {

        }

        public override string Context
        {
            get
            {
                //文本类型设置邮件格式为：text/plain
                string str = $"Content-Type: text/plain;charset-GB2312 {base.Context}";
                return $"{str}\n邮件格式为：文本格式";
            }
        }
    }
}
