namespace Komplettering_Labb3.DataModels.Products;

public abstract class Product
{
    public string Name { get; set; }

    public bool Price { get; set; }

    protected Product(string name, bool price)
    {
        Name = name;
        Price = price;
    }
}