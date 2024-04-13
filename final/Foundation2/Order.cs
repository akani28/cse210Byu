class Order
{
    private Customer _customer;
    private List<Product> products = new List<Product>();
    public Order(Customer customer)
    {
        _customer = customer;

    }

    public List<Product> GetProducts()
    {
        return products;
    }

    public void SetProducts(Product product)
    {
        products.Add(product);

    }
}