using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EFModels.Enum
{  
    public enum EnumSysRole
    {
        [Description("管理员")]
        Manager = 1,
        [Description("平台使用者")]
        User = 2
    }
}