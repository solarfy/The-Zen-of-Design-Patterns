using System;

namespace ZenOfDesignPattern.Prototype_Pattern
{
    /* 原型模式；通过拷贝原型实例创建对象。
     * [对于引用类型一般情况下Copy是浅拷贝，Clone是深拷贝；对于值类型就没什么区别]
     */

    class Subject : ICloneable
    {
        public string Title { get; set; }
        public string Context { get; set; }
        public SubjectPart Part { get; set; }

        public Subject() { }

        ////方法二，通过私有构造函数，实现深拷贝
        //private Subject(SubjectPart part)
        //{
        //    this.Part = (SubjectPart)part.Clone();
        //}

        //public object Clone()
        //{            
        //    Subject subject = new Subject(this.Part);
        //    subject.Title = this.Title;
        //    subject.Context = this.Context;
        //    return subject;
        //}

        public object Clone()
        {
            Subject subject = (Subject)this.MemberwiseClone();
            subject.Part = (SubjectPart)this.Part.Clone();      //注释掉此句变为浅拷贝
            return subject;
        }
    }

    class SubjectPart : ICloneable
    {
        public int Count { get; set; }

        public object Clone()
        {
            //MemberwiseClone();字段是值类型，则进行逐位复制；如果字段是引用类型，则只复制引用不复制引用的对象。
            return (SubjectPart)this.MemberwiseClone();
        }
    }
}
