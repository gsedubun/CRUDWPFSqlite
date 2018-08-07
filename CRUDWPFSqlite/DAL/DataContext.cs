using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;

namespace CRUDWPFSqlite.DAL
{
    public class DataContext : DbContext
    {
        //public DataContext() : base(new SQLiteConnection()
        //    {
        //        ConnectionString =  new SQLiteConnectionStringBuilder()
        //        {
        //            DataSource= "C:\\Users\\gadael.sedubun\\Downloads\\CRUDWPFSqlite\\CRUDWPFSqlite\\CRUDWPFdb.db", ForeignKeys=true
        //        }.ConnectionString
        //    },true)
        //{

        //}
        public DataContext() : base("crud")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //var sqliteConnInit = new SqliteCreateDatabaseIfNotExists
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<Contact> Contact { get; set; }

    }
}
