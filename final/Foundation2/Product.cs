public class Product 
{
     private string _productName;

     private int _productID;
     private float _price;

     private int _quantity;

     public Product(string productName, float price, int quantity, int productID)
     {
          _productName = productName;
          _price = price;
          _quantity = quantity;
          _productID = productID;
     }

     public int productID()
     {
          return _productID;
     }

     public string ProductName()
     {
          return _productName;
     }

     public int  GetQuantity()
     {
          return _quantity;
     }

       public float  GetPrice()
     {
          return _price *_quantity; 
     }
}
