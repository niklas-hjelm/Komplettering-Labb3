namespace Komplettering_Labb3.DataModels.Products;

public abstract class Product
{
    public string Name { get; set; }

    public double Price { get; set; }

    protected Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}