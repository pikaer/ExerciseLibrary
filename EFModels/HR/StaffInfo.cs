using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFModels.HR
{
    [Table("HR_StaffInfo")]
    public class StaffInfo:Entity<int>
    {
        /// <summary>
        /// 登录名
        /// </summary>
        public String LoginName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public String PassWord { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public String RealName { get; set; }
        /// <summary>
        /// 性别  false为女，ture为男
        /// </summary>
        public Boolean Sex { get; set; }
        /// <summary>
        /// 出生年月
        /// </summary>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public String Email { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public String Degree { get; set; }
        /// <summary>
        /// 所在学校
        /// </summary>
        public String School { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public String Mobile { get; set; }
        /// <summary>
        /// QQ号
        /// </summary>
        public String QQ { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        public Boolean Enabled { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public String Description { get; set; }
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
        /// 银行卡号
        /// </summary>
        public String IdCard { get; set; }
    }
}
