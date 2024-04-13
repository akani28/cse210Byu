class Product
{
    private string _name;
    private string _id;
    private float _price;
    private int _amount;
    private float totalCost;
    public Product(string name, string id, float price)
    {
        _name = name;
        _id = id;
        _price = price;
       
    }

    public float TotalCost()
    {
        totalCost = _amount * _price;
        return totalCost;
    }

    public void DetailsProduct()
    {
        Console.WriteLine($"{_name} Id: {001} Price: {_price}$");
    }

    public int GetAmount()
    {
        return _amount;
    }
    public void SetAmount(int amount)
    {
        _amount = amount;

    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;

    }
}