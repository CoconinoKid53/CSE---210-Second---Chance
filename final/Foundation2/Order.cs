 public class Order
 {
  List<Product> products = new List<Product>();
  private Customer _customer;

   

    public  Order(List<Product>products,Customer customer)
    {
      this.products = products;
      _customer = customer;
      
     
    }

    public double TotalPrice(double TotalPrice = 0)
    {
      foreach(Product product in products)
      {
        TotalPrice += product.GetPrice();
      }
      TotalPrice += _customer.IsinUSA() ? 1:0;
      return TotalPrice;
    }
    public  string _packingLabel()
    {
       string _packLable  = "";
      foreach(Product product in products){
        _packLable += product.ProductName() + "-----";
        _packLable += product.productID()+ "\n";
      }
  return _packLable;
    }

    public  string GetOrder()
    {
      return $"{_customer.Getname()}, {_customer.address1()}";
    }

  
 }