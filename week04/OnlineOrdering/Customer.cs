using System;

public class Customer
{
    private string _customerName= "";

    private Address _customerAddress;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetCustomerAddress()
    {
        return _customerAddress;
    }


    public bool LivesInUSA()
    {
        return _customerAddress.IsFromUSA();

    }


}