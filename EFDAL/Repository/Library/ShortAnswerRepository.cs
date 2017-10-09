using EFDAL.IRepository.Library;
using EFModels.Library;
using EnCapEntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDAL.Repository.Library
{
    [Export(typeof(IShortAnswerRepository))]
    public class ShortAnswerRepository : Repository<ShortAnswer>, IShortAnswerRepository
    {
    }
}
