using System;
using System.Net.Http.Headers;


public class Order
{
    private List<Product> _products;
    private Costumer _costumer;

    public Order(List<Product> products, Costumer costumer)
    {

    }

    public float CalculateTotalCost()
    {

    }

    public string GetPackingLabel()
    {

    }

    public string GetShippingLabel()
    {
        
    }
}