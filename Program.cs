using ConsoleApp1;
using System;

public class Program
{
    public static void Main()
    {
        Store store = new Store();


        store.AddProduct(new Toy(20m, "Пластик", "Плюшевый медведь" )); 
        store.AddProduct(new Meat(50m, "мясо", "Говядина"));
        store.AddProduct(new Meat(21m, "Рыба", "Окунь"));
        store.AddProduct(new Drink(15m, "1L","Milk"));


        store.DisplayProducts();
    }
}