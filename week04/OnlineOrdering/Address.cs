using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _province;

    private string _country;

    public Address(string street, string city, string state, string province, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _province = province;
        _country = country;
    }

    public bool IsFromUSA()
    {
        return _country.ToUpper() == "USA";

    }

    public string GetDisplayAll()
    {
        if (_country == "USA")
        {
            return $"{_streetAddress}\n{_city}\n{_state}\n{_country}";
        }

        else
        {
            return $"{_streetAddress}\n{_city}\n{_province}\n{_country}";
        }
    }
}