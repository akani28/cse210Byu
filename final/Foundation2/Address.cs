class Address
{
    private string _postalAddress;
    private string _city;
    private string _state;
    private string _country;
    public Address(string postalAddress, string city, string state, string country)
    {
        _postalAddress = postalAddress;
        _city = city;
        _state = state;
        _country = country;


    }

    public string ShowAddress()
    {
        return $"{_postalAddress}/{_city}/{_state}/{_country}";
    }

    public Boolean LocationUE()
    {
        if (_country == "EE.UU.")
        {
            return true;
        }
        return false;
    }
}