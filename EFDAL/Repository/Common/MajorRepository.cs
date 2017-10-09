using EFDAL.IRepository.Common;
using EFModels.Common;
using EnCapEntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDAL.Repository.Common
{
    [Export(typeof(IMajorRepository))]
    public class MajorRepository : Repository<Major>, IMajorRepository
    {
    }
}
