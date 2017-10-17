using EFModels.Common;
using EnCapEntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDAL.MapConfigurations.Common
{
    [Export(typeof(IEntityMapper))]
    public class MajorConfiguration : EntityTypeConfiguration<Major>, IEntityMapper
    {
        public MajorConfiguration()
        {

        }
        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }
}
