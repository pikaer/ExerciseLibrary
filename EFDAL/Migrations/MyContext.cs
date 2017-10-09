using EnCapEntityFrameWork;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EFDAL
{
    [Export(typeof(DbContext))]
    public class MyContext : EFDbContext
    {
        public MyContext()
            : base()
        {
        }
        /// <summary>
        /// 属性容器注入Configurations文件夹下的
        /// [Export]
        /// XXXXConfiguration
        /// </summary>
        [ImportMany(typeof(IEntityMapper))]
        public IEnumerable<IEntityMapper> EntityMappers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //默认全局禁用级联删除
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //默认全局禁用级联删除
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //禁用自动生成数据表末尾加s或者es
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //移除不必要的契约
            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            if (EntityMappers == null)
            {
                return;
            }

            foreach (var mapper in EntityMappers)
            {
                mapper.RegistTo(modelBuilder.Configurations);
            }
        }
    }
}
