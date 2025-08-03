// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System;

public class Program
{

    private static void Main(string[] args)
    {
        var context = new NorthwindContext();

 



        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetAll())
        {
            Console.WriteLine(product.ProductName);
        }

        Console.WriteLine("Can not get");


    }
  
}
