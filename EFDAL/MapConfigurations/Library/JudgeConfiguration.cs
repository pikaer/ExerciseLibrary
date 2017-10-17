using EFModels.Library;
using EnCapEntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDAL.MapConfigurations.Library
{
    [Export(typeof(IEntityMapper))]
    public class JudgeConfiguration : EntityTypeConfiguration<Judge>, IEntityMapper
    {
        public JudgeConfiguration()
        {

        }

        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }
}
