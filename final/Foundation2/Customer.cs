public  class Customer
{
    private string _CustomerName;

    private Address  _address;


    public Customer(string CustomerName, Address address)
    {
        _CustomerName = CustomerName;
        _address = address;
    }

    public string Getname()
    {
        return _CustomerName;
    }
      public bool IsinUSA()
   {
    return _address.IsinUSA();
   }

 
   public Address address1()
   {
    return _address;

   }
    




}