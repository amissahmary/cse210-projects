using System;

public class Customer{
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public bool Location(){
        return _address.Citizenship() == "USA";
        }

    public string DisplayCustomerInfo(){
        return $"Customer name: {_name}\n{_address.DisplayAddress()}";
    }
}