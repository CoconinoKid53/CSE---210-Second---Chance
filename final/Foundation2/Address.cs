using System.Xml.Serialization;

public class Address
{
    private string _StreetAddress;

    private string _City;

    private string _CountryName;


    private int _zipCode;
    
    public Address(string StreetAddress, string City, string CountryName, int ZipCode) 
    {
        _StreetAddress = StreetAddress;
        _City = City;
        _CountryName = CountryName;
        _zipCode = ZipCode;
    }

    public bool IsinUSA()
    {
        return _StreetAddress == "USA";
    }

 
    public string GetAddress()
    {
        return  $"{_StreetAddress}, {_City}, {_CountryName}, {_zipCode}";
    }
}