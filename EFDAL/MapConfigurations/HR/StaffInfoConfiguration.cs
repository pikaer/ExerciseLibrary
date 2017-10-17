using EFModels.HR;
using EnCapEntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDAL.MapConfigurations.HR
{
    [Export(typeof(IEntityMapper))]
    public class StaffInfoConfiguration : EntityTypeConfiguration<StaffInfo>, IEntityMapper
    {
        public StaffInfoConfiguration()
        {

        }

    public void RegistTo(ConfigurationRegistrar configurations)
    {
        configurations.Add(this);
    }
}
    
}
