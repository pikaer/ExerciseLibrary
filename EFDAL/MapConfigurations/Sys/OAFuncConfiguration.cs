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
    public class OAFuncConfiguration : EntityTypeConfiguration<OAFunc>, IEntityMapper
    {
        public OAFuncConfiguration()
        {
            this.HasOptional(a => a.Parent)
                .WithMany(b => b.Children)
                .HasForeignKey(c => c.ParentId)
                .WillCascadeOnDelete(false);
        }

        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }
}
