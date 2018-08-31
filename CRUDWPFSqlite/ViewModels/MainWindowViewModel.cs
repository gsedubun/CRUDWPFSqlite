using CRUDWPFSqlite.DAL;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWPFSqlite.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private PhoneBookRepository PhoneBookRepo;
        private Contact _Contact;

        private IEnumerable<Contact> _Contacts;
        public IEnumerable<Contact> Contacts
        {
            get { return _Contacts; }
            set { SetProperty(ref _Contacts, value); }
        }

        public Contact Contact
        {
            get { return _Contact; }
            set
            {
                SetProperty(ref _Contact, value);
            }
        }
        public DelegateCommand SubmitCmd { get; set; }

        public MainWindowViewModel()
        {
            PhoneBookRepo = new PhoneBookRepository();
            ResetGrid();
            Contact = new Contact();
            this.SubmitCmd = new DelegateCommand(Submit, CanSubmit);
        }
        private void ResetGrid()
        {
            Contacts = PhoneBookRepo.Select();

        }
        private void Submit()
        {
            if (Contact.ContactId == 0)
            {
                PhoneBookRepo.Add(Contact);
            }
            else
                PhoneBookRepo.Update(Contact.ContactId, Contact);
            ResetGrid();
        }

        private bool CanSubmit()
        {
            //   return !String.IsNullOrEmpty(_Contact.Name) && !string.IsNullOrEmpty(_Contact.Email) && !String.IsNullOrEmpty(_Contact.PhoneNumber);
            return true;
        }
    }
}
