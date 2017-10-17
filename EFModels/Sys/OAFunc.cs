using EFModels.Enum;
using EFUltilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Sys
{
    public class OAFunc : Entity<int>
    {
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

        [NotMapped]
        public string EnumFuncTypeDescrib
        {
            get
            {
                return EnumFuncType.ToDescription();
            }
        }
        
        [JsonIgnore]
        public OAFunc Parent { get; set; }
        public List<OAFunc> Children { get; set; }
        public List<MapOfFuncAndRole> MapOfFuncAndRole { get; set; }

        public bool IsBindToRole(int RoleId)
        {
            return MapOfFuncAndRole != null && MapOfFuncAndRole.Any(a => a.SysRoleId == RoleId);
        }
    }
}
