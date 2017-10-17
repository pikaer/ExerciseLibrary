using EFModels.Enum;
using EFUltilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Sys
{
    public class SysRole : Entity<int>
    {
        public string Name { get; set; }
        public EnumSysRole EnumSysRole { get; set; }
        public string Describ { get; set; }

        [NotMapped]
        public string EnumSysRoleDescrib
        {
            get
            {
                return EnumSysRole.ToDescription();
            }
        }
    }
}
