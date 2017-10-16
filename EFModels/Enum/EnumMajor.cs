using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Enum
{
    [Flags]
    public enum EnumMajor
    {
        [Description("语文")]
        Chinese=1,
        [Description("数学")]
        Math = 2,
        [Description("英语")]
        English = 3,
        [Description("物理")]
        Phusics = 4,
        [Description("化学")]
        Chemistry = 5,
        [Description("生物")]
        Biology=6,
        [Description("地理")]
        Geography = 7,
        [Description("政治")]
        Politics = 8,
        [Description("历史")]
        History = 9,
    }
}
