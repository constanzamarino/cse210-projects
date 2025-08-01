using System;
using System.Collections.Generic;



public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
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
        string packinglabel = "";

        foreach (Product product in _products)
        {
            packinglabel += $"{product.GetProductName()}\n";
            packinglabel += $"{product.GetProductID()}\n";
        }
        return packinglabel;
    }

    public string GetShippingLabel()
    {
        string shippinglabel = "";

        shippinglabel += $"{_customer.GetCustomerName()}\n";
        shippinglabel += $"{_customer.GetCustomerAddress().GetDisplayAll()}\n";

        return shippinglabel;


    }
    

  
}