public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name)
    {   
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }

    public bool LiveInUsa()
    {
        if(_address.LiveInUsa())
        {
            return true;
        }
        return false;
    }

    public string DisplayAddress()
    {
        return _address.DisplayAll();
    }
}