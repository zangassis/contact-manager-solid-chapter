namespace ContactManager.Models;

public class Email
{
    public string Address { get; set; }
    public virtual string GetEmailType()
    {
        return "Generic Email";
    }
}