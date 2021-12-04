using System;
  
public class DemoEncap {
      
    // private variables declared
    // these can only be accessed by
    // public methods of class
    private String CarName;
    private int CarPrice;
      
    // using accessors to get and 
    // set the value of CarName
    public String Name
    {
          
        get
        {
            return CarName;    
        }
          
        set 
        {
            CarName = value;
        }
          
    }
      
    // using accessors to get and 
    // set the value of CarPrice
    public int Price
    {
          
        get 
        {
            return CarPrice;    
        }
          
        set 
        {
            CarPrice = value;
        }
          
    }
  
      
}
  
// Driver Class
class Encapsulation {
      
    // Main Method
    static public void Main()
    {
          
        // creating object
        DemoEncap obj = new DemoEncap();
  
        // calls set accessor of the property Name, 
        // and pass "BMW" as value of the 
        // standard field 'value'
        obj.Name = "BMW";
          
        // calls set accessor of the property Price, 
        // and pass "120000" as value of the 
        // standard field 'value'
        obj.Price = 120000;
  
        // Displaying values of the variables
        Console.WriteLine("\nName : " + obj.Name);
        Console.WriteLine("\nPrice : " + obj.Price);
        Console.ReadLine();
    }
}