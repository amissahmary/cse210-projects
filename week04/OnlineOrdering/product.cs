using System;

public class Product{
    private string _productName;
    private string _id;
    private double _price;
    private int _quantity;

    public void SetProductName(string productName){
        _productName = productName;
    }

    public void SetId(string id){
        _id = id;
    }

    public void SetPrice(double price){
        _price = price;
    }

    public void SetQuantity(int quantity){
        _quantity = quantity;
    }

    public string GetProductName(){
        return _productName;
    }

    public string GetId(){
        return _id;
    }

    public double GetPrice(){
        return _price;
    }

    public int GetQuantity(){
        return _quantity;
    }

    public string ProductInfo(){
        return $"Name of product: {_productName}\nID: {_id}";
    }

    public double CalculateCost(){
        return _price * _quantity;
    }
}