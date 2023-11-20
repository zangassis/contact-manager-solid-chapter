using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ContactManager.Models;

public class Contact : BaseContact
{
    public Contact(string? id, string? name, string? phoneNumber, string? emailAddress, DateTimeOffset createdOn, string type)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        EmailAddress = emailAddress;
        CreatedOn = createdOn;
        Type = type;
    }

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("name")]
    public string? Name { get; set; }

    [BsonElement("phone_number")]
    public string? PhoneNumber { get; set; }

    [BsonElement("email_address")]
    public string? EmailAddress { get; set; }

    [BsonElement("created_on")]
    public DateTimeOffset CreatedOn { get; set; }

    [BsonElement("type")]
    public string Type { get; set; }

    [BsonElement("priority")]
    public int Priority { get; set; }

    public override int GetPriority()
    {
        return 1;
    }
}