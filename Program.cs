using ContactManager.Models;
using ContactManager.Repositories;
using ContactManager.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<ContactDbSettings>(builder.Configuration.GetSection("ContactDbSettings"));
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddTransient<IContactService, ContactService>();

var app = builder.Build();

app.MapGet("/contacts", async (IContactService service) =>
{
    var contacts = await service.FindAllContacts();
    if (!contacts.Any())
        return Results.NotFound();
    return Results.Ok(contacts);
});

app.MapPost("/contacts", async (IContactService service, Contact contact) =>
{
    await service.CreateContact(contact);
    return Results.NoContent();
});

app.MapGet("/email", (IContactService service) =>
{
    service.ProcessEmail();
    return Results.NoContent();
});

app.Run();
