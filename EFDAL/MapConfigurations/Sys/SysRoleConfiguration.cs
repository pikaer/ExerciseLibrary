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
    public class SysRoleConfiguration : EntityTypeConfiguration<SysRole>, IEntityMapper
    {
        public SysRoleConfiguration()
        {

        }

        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }
}
