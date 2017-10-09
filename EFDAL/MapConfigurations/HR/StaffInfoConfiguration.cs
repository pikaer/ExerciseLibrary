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
            //this.HasRequired(a => a.ProjInfo).WithMany(b => b.TabProjResultCheckStep).HasForeignKey(b => b.ProjId);
            //this.HasOptional(a => a.CurrentStaff).WithMany().HasForeignKey(b => b.CurrentStaffId);
            //this.HasOptional(a => a.SelfChecker).WithMany().HasForeignKey(b => b.SelfCheckId);
            //this.HasOptional(a => a.ReChecker).WithMany().HasForeignKey(b => b.ReCheckId);
            //this.HasOptional(a => a.JudgeReviewer).WithMany().HasForeignKey(b => b.JudgeReviewId);
            //this.HasOptional(a => a.Finalizerer).WithMany().HasForeignKey(b => b.FinalizerId);
            //this.HasOptional(a => a.FlowInst).WithMany().HasForeignKey(b => b.FlowInstId);
        }

        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }
    
}
