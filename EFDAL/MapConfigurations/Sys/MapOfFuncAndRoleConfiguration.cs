using EFModels.Sys;
using EnCapEntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDAL.MapConfigurations.Sys
{
    [Export(typeof(IEntityMapper))]
    public class MapOfFuncAndRoleConfiguration : EntityTypeConfiguration<MapOfFuncAndRole>, IEntityMapper
    {
        public MapOfFuncAndRoleConfiguration()
        {
            this.HasRequired(a => a.SysRole).WithMany().HasForeignKey(a => a.SysRoleId);
            this.HasRequired(a => a.OAFunc).WithMany(a => a.MapOfFuncAndRole).HasForeignKey(a => a.OAFuncId);
        }

        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }
}
