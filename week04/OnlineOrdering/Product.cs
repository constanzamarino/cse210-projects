using System;

public class Product
{
    private string _productName = "";
    private int _productID;

    private float _price;

    private int _productQuantity;

    public Product(string name, int ID, float price, int quantity)
    {
        _productName = name;
        _productID = ID;
        _price = price;
        _productQuantity = quantity;

    }

    public float GetTotalCost()
    {
        float totalcost = _price * _productQuantity;
        return totalcost;
    }
    
    
}