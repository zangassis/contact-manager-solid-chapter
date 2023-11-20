using ContactManager.Models;

namespace ContactManager.Repositories
{
    public interface IContactRepository
    {
        Task Create(Contact contact);
        Task<List<Contact>> FindAllContacts();
    }
}