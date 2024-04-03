using System;
using System.Collections.Generic;
using System.Linq;


public class Products
{
  public string name { get; set; }
  public int price { get; set; }
  public int stock { get; set; }

}

public class Exam
{
    public static void Main(string[] args)
    {
       //create product list
       var productslist = new List<Products>(){ 
                new Products(){ name="Product A", price = 100, stock=5},
                new Products(){ name="Product B", price = 200, stock=3},
                new Products(){ name="Product C", price = 50, stock=10}
            };
            
       //call function order by price and descending
       Console.WriteLine("first function call: order by price and descending \n");
       orderList(productslist,"price",false);
       
       //call function order by price and ascending
       Console.WriteLine("\nsecond function call: order by price and descending \n");
       orderList(productslist,"price",true);
       
       //call function order by stock and ascending
       Console.WriteLine("\nthird function call: order by stock and ascending \n");
       orderList(productslist,"stock",true);
       
       //call function order by stock and descending
       Console.WriteLine("\nfourth function call: order by stock and ascending \n");
       orderList(productslist,"stock",false);
    }
    
    
                
        //function orderList
        public static IEnumerable<Products> orderList(List<Products> plist, string sort_key, bool ascending){
        
        IEnumerable<Products> productsListSorted = Enumerable.Empty<Products>();

        // order by ascending depending on sort type 
        if(ascending==true){
        if(sort_key=="price")
        productsListSorted = plist.OrderBy(p => p.price);
        else if(sort_key=="name")
        productsListSorted = plist.OrderBy(p => p.name);
        else if(sort_key=="stock")
        productsListSorted = plist.OrderBy(p => p.stock);
        else
        throw new InvalidOperationException("sort type is not valid");
        }

         // order by descending depending on sort type
        if(ascending==false){
        if(sort_key=="price")
        productsListSorted = plist.OrderByDescending(p => p.price);
        else if(sort_key=="name")
        productsListSorted = plist.OrderByDescending(p => p.name);
        else if(sort_key=="stock")
        productsListSorted = plist.OrderByDescending(p => p.stock);
        else
        throw new InvalidOperationException("sort type is not valid");
        }

        //print the ordered result
       foreach (var item in productsListSorted)
        {
            Console.WriteLine($"name: {item.name}, price: {item.price}, stock {item.stock}");
        }
        
        return productsListSorted;
        }
}
