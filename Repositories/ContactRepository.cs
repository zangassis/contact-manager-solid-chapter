using ContactManager.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ContactManager.Repositories;

public class ContactRepository : IContactRepository
{
    private readonly IMongoCollection<Contact> _contacts;

    public ContactRepository(IOptions<ContactDbSettings> options)
    {
        var mongoClient = new MongoClient(options.Value.ConnectionString);

        _contacts = mongoClient
            .GetDatabase(options.Value.DatabaseName)
            .GetCollection<Contact>(options.Value.CollectionName);
    }

    public async Task<List<Contact>> FindAllContacts()
    {
        if (_contacts == null)
            return new List<Contact>();

        return await _contacts.Find(_ => true).ToListAsync();
    }

    public async Task Create(Contact contact)
    {
        await _contacts.InsertOneAsync(contact);
    }
}