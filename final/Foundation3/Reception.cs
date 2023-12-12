public class Reception : Events
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email): base(title, description, date, time, address)
    {
        _email = email;
    }

    public void FullDetails()
    {
        StandardDetails();
        Console.Write("\n- Email for Registering: " + _email);
    }
}