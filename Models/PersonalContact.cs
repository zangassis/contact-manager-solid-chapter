namespace ContactManager.Models;

public class PersonalContact : BaseContact
{
    public override int GetPriority()
    {
        return 2;
    }
}