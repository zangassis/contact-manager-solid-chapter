namespace ContactManager.Models;

public class ProfessionalEmail : Email
{
    public string CompanyName { get; set; }

    public override string GetEmailType()
    {
        return "Professional Email";
    }
}