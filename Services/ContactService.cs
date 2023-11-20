using ContactManager.Models;
using ContactManager.Repositories;

namespace ContactManager.Services;

public class ContactService : IContactService
{
    private readonly IContactRepository _contactRepository;

    public ContactService(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }

    public async Task<List<Contact>> FindAllContacts()
    {
        return await _contactRepository.FindAllContacts();
    }

    public async Task CreateContact(Contact contact)
    {
        contact.Priority = contact.GetPriority();
        await _contactRepository.Create(contact);
    }

    public void ProcessEmail()
    {
        Email email = new Email();
        Email personalEmail = new PersonalEmail();
        Email professionalEmail = new ProfessionalEmail();

        string type1 = GetType(personalEmail);
        Console.WriteLine(type1);

        string type2 = GetType(professionalEmail);
        Console.WriteLine(type2);

        string type3 = GetType(email);
        Console.WriteLine(type3);
    }

    public string GetType(Email email)
    {
        return email.GetEmailType();
    }
}