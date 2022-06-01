using System;
using System.ComponentModel;

namespace MixedMode.Observer_Mediator
{
    //事件处理权限枚举
    [Flags]
    enum EventCustomerType
    {
        [Description("新建")]
        NEW = 1 << 0,

        [Description("删除")]
        DEL = 1 << 1,

        [Description("修改")]
        EDIT = 1 << 2,

        [Description("克隆")]
        CLONE = 1 << 3,
    }
}
