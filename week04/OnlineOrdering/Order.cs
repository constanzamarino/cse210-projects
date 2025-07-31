using System;
using System.Collections.Generic;


public class Order
{
    private List<Product> _products;
    private Customer _costumer;

    public Order(List<Product> products, Customer costumer)
    {
        _products = products;
        _costumer = costumer;
    }

    public float CalculateTotalCost()
    {
        float total = 0;
        
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        return total;
    }

    public string GetPackingLabel()
    {
        //Add code
    }

    public string GetShippingLabel()
    {
        //Add code
    }

  
}