using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            
            //Enter a date of birth(day,month,year) in DateTime( , , )
            
            customerManager.Save(new Customer{DateOfBirth = new DateTime( , , ), FirstName = "Enter a name", LastName = "Enter a lastname", NatId= "Enter a nationality Id" });
            Console.ReadLine();
        }
    }

    

}
