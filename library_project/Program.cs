using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //library project
            // KİTAPLIĞIN MENÜSÜ.
            // menü sınıfından bir nesne oluşturduk
            menü menü = new menü(); 
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("     Welcome To The Library    ");
            Console.WriteLine();
            Console.WriteLine("*****  MENU  *****");
            Console.WriteLine("1- Local Books");
            Console.WriteLine("2- foreign books");
            Console.WriteLine("3- Yazarlar ");
            Console.WriteLine("4- Satın Alma İşlemi");
            Console.WriteLine();
            Console.WriteLine("Gitmek istediğiniz yer ?");
            Console.Write(">>> ");
            string choice = (Console.ReadLine());
            while (choice != null) {
 
                switch (choice)
                {
                    case "Local Books":
                        menü.LocalBooks();
                        break;
                    case "foreign books":
                        menü.foreignbooks();
                        break;
                    case "writers":
                        menü.writers();
                        break;
                    case "buy":
                        menü.buy();
                        break;
                }
                Console.WriteLine("Where do you want to go on the menu?");
                Console.Write(">>> ");
                choice = (Console.ReadLine());
            }





            


            Console.ReadKey();





        }    
         
 


    }
}
