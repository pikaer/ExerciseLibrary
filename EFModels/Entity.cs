using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels
{
    [Serializable]
    public abstract class Entity<TKey>
    {
        #region 构造函数

        /// <summary>
        /// 数据实体基类
        /// </summary>
        protected Entity()
        {
            CreateTime = DateTime.Now;
        }

        #endregion
        
        /// <summary>
        /// 获取或设置 添加时间
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime CreateTime { get; set; }
        
        //[Key]
        // 不一定作为主键，有时候要派生类指定主键 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual TKey Id { get; set; }
    }
}
