using System;
using System.Collections.Generic;

public class Order{
    private double _shippingCost1 = 5.0;
    private double _shippingCost2 = 35.0;
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer){
    _customer = customer;
    }

    public string ShippingLabel(){
        return $"{_customer.DisplayCustomerInfo()}\n";
    }

    public string PackingLabel(){
        string result = "";
        foreach(Product product in _products){
            result += product.ProductInfo() + "\n";
        }
        return result;
    }

    public void ProductList(Product product){
        _products.Add(product);
    }

    public double CalculateTotalCost(){
        double cost = 0;
        foreach(Product pro in _products){
            cost += pro.CalculateCost();
        }
        if(_customer.Location()){
            return cost + _shippingCost1;
        } 
        else{
            return cost + _shippingCost2;
        }
    }
}