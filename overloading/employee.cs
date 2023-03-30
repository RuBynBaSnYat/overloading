using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    internal class employee
    {
        public string fullname;
    }
    internal class FTE : employee
    {
        private int monthlysalary;
        public static void Main(string[] args)
        {
            FTE FTemployee= new FTE();
            Console.WriteLine("Enter a Fullname of employee");
            FTemployee.fullname=Console.ReadLine();
            Console.WriteLine("enter a monthly salary ");
            FTemployee.monthlysalary=(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Year Salary of FTE = " + 12 *FTemployee.monthlysalary);
        }
         
    }
    internal class PTE:employee
    {
        private int workinghrs;
        private int hourlyrate;
        public static void Main(string[] args)
        {
         PTE PTemployee= new PTE();
            Console.WriteLine("Enter the full name of part time employee");
            PTemployee.fullname = Console.ReadLine();
            Console.WriteLine("Enter a time of working = ");
            PTemployee.workinghrs=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a hourly rate= ");
            PTemployee.hourlyrate=(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Year salary of PTE = " + PTemployee.workinghrs * PTemployee.hourlyrate);


        }
    }
}
