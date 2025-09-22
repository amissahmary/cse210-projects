using System;

public class Address{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country){
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string Citizenship(){
            return _country;
        }

    public string DisplayAddress(){
        return $"Street: {_streetAddress}\nCity: {_city}\nState: {_state}\nCountry: {_country}";
    }
}