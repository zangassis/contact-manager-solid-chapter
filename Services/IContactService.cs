using System.Diagnostics;
using ContactManager.Models;

namespace ContactManager.Services
{
    public interface IContactService
    {
        Task CreateContact(Contact contact);
        Task<List<Contact>> FindAllContacts();
        void ProcessEmail();
    }
}