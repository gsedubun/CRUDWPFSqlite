using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDWPFSqlite.DAL
{
    [Table(name:"Contact")]
    public class Contact
    {
        [Key]
        [Column("ContactId", TypeName = "INTEGER")]
        public int ContactId { get; set; }

        [Column("Name",TypeName ="VARCHAR")]
        public string Name { get; set; }

        [Column("PhoneNumber",TypeName = "VARCHAR")]
        public string PhoneNumber { get; set; }

        [Column("Email",TypeName = "VARCHAR")]
        public string Email { get; set; }

    }
}
