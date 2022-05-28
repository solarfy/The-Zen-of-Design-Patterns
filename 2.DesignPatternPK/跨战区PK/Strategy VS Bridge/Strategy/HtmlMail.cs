namespace DesignPatternPK.Strategy_VS_Bridge.Strategy
{
    class HtmlMail : AbsMailTemplate
    {
        public HtmlMail(string _from, string _to, string _subject, string _context) : base(_from, _to, _subject, _context)
        {

        }

        public override string Context
        {
            get 
            {
                //文本类型设置邮件格式为：multipart/mixed
                string str = $"Content-Type: multipart/mixed;charset=GB2312 {base.Context}";
                return $"{str}\n邮件格式：超文本格式";
            }
        }
    }
}
