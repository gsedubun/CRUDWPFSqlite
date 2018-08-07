using System.Collections.Generic;

namespace CRUDWPFSqlite.DAL
{
    public interface IPhoneBookRepository
    {
        int Add(Contact contact);
        int Delete(int contactId);
        Contact Update(int contactId, Contact contact);
        IEnumerable<Contact> Select();
        Contact Select(int contactId);
    }
}
