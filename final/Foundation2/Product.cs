class Product
{
    private string _name;
    private string _id;
    private float _price;
    private int _amount;
    private float totalCost;
    public Product(string name, string id, float price, int amount)
    {
        _name = name;
        _id = id;
        _price = price;
        _amount = amount;
    }

    public float TotalCost()
    {
        return _amount * _price;
    }
}