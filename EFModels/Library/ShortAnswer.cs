using EFModels.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Library
{
    [Table("Library_ShortAnswer")]   //简答题
    public class ShortAnswer : Entity<int>
    {
        /// <summary>
        /// 题目
        /// </summary>
        public String Title { get; set; }
        /// <summary>
        /// 标准答案
        /// </summary>
        public String Answer { get; set; }
        /// <summary>
        /// 试题解析
        /// </summary>
        public String Analysis { get; set; }
        /// <summary>
        /// 试题难度
        /// </summary>
        public EnumDifficulty Difficulty { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public Int32 CreaterId { get; set; }
        /// <summary>
        /// 最近修改人
        /// </summary>
        public Int32 ModifierId { get; set; }
        /// <summary>
        /// 最近修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        /// <summary>
        /// 科目所属专业
        /// </summary>
        public Int32 MajorId { get; set; }
    }
}
