using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Enum
{
    [FlagsAttribute]
    public enum EnumDifficulty
    {
        [Description("☆")]
        One= 1,
        [Description("☆☆")]
        Two = 2,
        [Description("☆☆☆")]
        Three = 3,
        [Description("☆☆☆☆")]
        Four = 4,
        [Description("☆☆☆☆☆")]
        Five = 5,
    }
}
