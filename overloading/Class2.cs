using overloading;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    internal class car
    {
        public string Brand;
        public int model;
        public int price;
        
    }
    internal class suzuki : car
    {

        public static void Main(string[] args)
        {
            suzuki Alto = new suzuki();
            Alto.Brand = "alto";
            Alto.model = 5568;
            Alto.price = 100000000;
            Console.WriteLine("Brand: " + Alto.Brand);
            Console.WriteLine("Model: " + Alto.model);
            Console.WriteLine("Price: " + Alto.price);
        }
    }
    internal class Honda:car
    {
        double DiscountPrice;
        public double Calculatediscountprice(double price)
        { 
            return price*0.01;
        
        }
        public static void Main(string[] args)
        {
            Honda obj1=new Honda();
            obj1.Brand = "brand";
            obj1.price = 10000000;
            obj1.DiscountPrice = obj1.Calculatediscountprice(obj1.price);
            Console.WriteLine("Brand: " + obj1.Brand);
            Console.WriteLine("price: " + obj1.price);
            Console.WriteLine("discount: " + obj1.DiscountPrice);

        }
    }

}

    
   
