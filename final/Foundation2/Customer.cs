class Customer
{
    private string _name;
    private Address _address;
    public Customer()
    {

    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress()
    {
        Console.WriteLine("Postal address: ");
        string postalAddress= Console.ReadLine();
        Console.WriteLine("city: ");
        string city= Console.ReadLine();
        Console.WriteLine("state: ");
        string state= Console.ReadLine();
        Console.WriteLine("country: ");
        string country= Console.ReadLine();

        _address = new Address(postalAddress, city, state, country);
        
    }

    public void ReturnProduct()
    {

    }
}