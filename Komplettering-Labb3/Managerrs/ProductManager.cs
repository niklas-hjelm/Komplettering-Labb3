using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Komplettering_Labb3.DataModels.Products;

namespace Komplettering_Labb3.Managerrs;

public static class ProductManager
{
    private static readonly IEnumerable<Product>? _products = new List<Product>();
    public static IEnumerable<Product>? Products => _products;
    
    // Skicka detta efter att produktlistan ändrats eller lästs in
    public static event Action ProductListChanged;

    public static void AddProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public static void RemoveProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public static async Task SaveProductsToFile()
    {
        throw new NotImplementedException();
    }

    public static async Task LoadProductsFromFile()
    {
        throw new NotImplementedException();
    }
}