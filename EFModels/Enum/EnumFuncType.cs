using System.ComponentModel;

namespace EFModels.Enum
{
    public enum EnumFuncType
    {
        [Description("模块级")]
        Module = 1,
        [Description("菜单级")]
        Menu =2,
        [Description("页面级")]
        Page,
        [Description("按钮级")]
        Button,
    }
}
