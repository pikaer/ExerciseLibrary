using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Common
{
    [Table("Common_Major")]   //所属专业
    public class Major : Entity<int>
    {
        /// <summary>
        /// 专业对应的Id
        /// </summary>
        public Int32 MajorId { get; set; }
        /// <summary>
        /// 专业名称
        /// </summary>
        public String MajorName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public String Describ { get; set; }
    }
}
