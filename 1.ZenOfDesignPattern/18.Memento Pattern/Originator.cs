using System.Collections.Generic;

namespace ZenOfDesignPattern.Memento_Pattern
{
    //发起人；记录当前时刻的内部状态，负责创建和恢复备忘录数据
    class Originator
    {
        public string State1 { get; set; }
        public string State2 { get; set; }
        public string State3 { get; set; }

        public override string ToString()
        {
            return $"{State1} - {State2} - {State3}";
        }

        //创建备忘录
        public IMemento CreateMemento()
        {
            return new Memento(BeanUtils.BackupProp(this));
        }

        //恢复备忘录
        public void RestoreMemento(IMemento memento)
        {
            if (memento is Memento m)
                BeanUtils.RestoreProp(this, m.GetVlues());
            else
                throw new System.Exception("类型不匹配");
        }

        /* 备忘录角色；负责存储Originator发起人对象的内部状态，在需要的时候向发起人提供存储的数据
         * 备份是不能篡改的，采用内置类限制备份的阅读权限，保证只能是发起人可读。
         * 通过一个空接口，对外提供一个公共访问权限，但不能访问实际的字段。
         */
        private class Memento : IMemento
        {
            //存储备忘录数据
            private Dictionary<string, object> keyValues = new Dictionary<string, object>() { };

            //建立备份
            public Memento(Dictionary<string, object> values) => this.keyValues = values;

            //获取备份
            public Dictionary<string, object> GetVlues() => this.keyValues;

            //建立备份
            public void SetValues(Dictionary<string, object> values) => this.keyValues = values;
        }
    }
}
