using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Sys
{
    [Serializable]
    public class MapOfFuncAndRole : Entity<Guid>
    {
        public int OAFuncId { get; set; }
        public int SysRoleId { get; set; }

        public OAFunc OAFunc { get; set; }
        public SysRole SysRole { get; set; }
    }
}
