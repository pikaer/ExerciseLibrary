using EFDAL.IRepository.HR;
using EFModels.HR;
using EnCapEntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDAL.Repository.HR
{
    [Export(typeof(IStaffInfoRepository))]
    public class StaffInfoRepository: Repository<StaffInfo>, IStaffInfoRepository
    {
    }
}
