namespace ContactManager.Models;

public class PersonalEmail : Email
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string GetEmailType()
    {
        return "Personal Email";
    }
}