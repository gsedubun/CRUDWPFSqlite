using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWPFSqlite.DAL
{
    public class PhoneBookRepository : IPhoneBookRepository, IDisposable
    {
        private DataContext Database;

        public PhoneBookRepository()
        {
            this.Database = new DataContext();
        }
        public int Add(Contact contact)
        {
            Database.Contact.Add(contact);
            return Database.SaveChanges();
        }

        public int Delete(int contactId)
        {
           Contact c= Select(contactId);
            Database.Contact.Remove(c);
            return Database.SaveChanges();

        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public IEnumerable<Contact> Select()
        {
            return Database.Contact.ToList();
        }

        public Contact Select(int contactId)
        {
            Contact contact = Database.Contact.SingleOrDefault(d => d.ContactId == contactId);
            return contact;
        }

        public Contact Update(int contactId, Contact contact)
        {
            Contact _contact = Select(contactId);
            if (_contact != null)
            {
                _contact.Email = contact.Email;
                _contact.Name = contact.Name;
                _contact.PhoneNumber = contact.PhoneNumber;
                Database.Contact.Attach(_contact);
                int res = Database.SaveChanges();
                if (res > 0)
                    return _contact;
            }
            return null;
        }
    }
}
