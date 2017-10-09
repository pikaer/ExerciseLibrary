namespace EFDAL.Migrations
{
    using EnCapEntityFrameWork;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal sealed class Configuration : DbMigrationsConfiguration<MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            //SetHistoryContextFactory("System.Data.SqlClient", (connection, defaultSchema) => new MyHistoryContext(connection, defaultSchema));
        }
        
    }
}
