using EFModels.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBLL.DTO.Sys
{
    [Serializable]
    public class OAFuncDTO
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        /// <summary>
        /// 文本描述
        /// </summary>
        public String Text { get; set; }
        /// <summary>
        /// 可作为url，亦可作为控件id
        /// </summary>
        public String Attributes { get; set; }
        /// <summary>
        /// 顺序
        /// </summary>
        public int Order { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public String IconCls { get; set; }
        /// <summary>
        /// 功能类型
        /// </summary>
        public EnumFuncType EnumFuncType { get; set; }
    }
}
