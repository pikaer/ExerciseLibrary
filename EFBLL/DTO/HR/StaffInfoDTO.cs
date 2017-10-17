using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBLL.DTO.HR
{
    [Serializable]
    public class StaffInfoDTO
    {
        public int Id { get; set; }
        public String LoginName { get; set; }
        public String PassWord { get; set; }
        public String RealName { get; set; }
    }
}
