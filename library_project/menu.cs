using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_project
{
    internal class menü
    {
        public void LocalBooks()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine();
            //Console.WriteLine("     Yerli kitaplar     ");
            Console.WriteLine("1- Kürk Mantolu Madonna            6- Nutuk ");
            Console.WriteLine("2- Çalıkuşu                        7- Tutunamayanlar ");
            Console.WriteLine("3- Aylak Adam                      8- İstanbul Hatırası");
            Console.WriteLine("4- Yaprak Dökümü                   9- Huzursuzluk");
            Console.WriteLine("5- Kumral Ada Mavi Tuna            10- Aşk ");
        }
        public void foreignbooks()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("1- Körlük                              6- Bilinmeyen Bir Kadının Öyküsü");
            Console.WriteLine("2- Başlangıç                           7- Amok koşucusu");
            Console.WriteLine("3- Trendeki kız                        8- Satranç");
            Console.WriteLine("4- Suç ve Ceza                         9- Fahrenheit 451");
            Console.WriteLine("5- Küçük Prens                         10- Kafes");
        }
        public void writers()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("1- Sabahattin Ali                      10- Jose Saramago");
            Console.WriteLine("2- Reşat Nuri Güntekin                 11- Fyodor Dostoyevski ");
            Console.WriteLine("3- Mustafa Kemal Atatürk               12- Stefan Zweig");
            Console.WriteLine("4- Buket Uzuner                        13- Ray Bradbury");
            Console.WriteLine("5- Yusuf Atılgan                       14- Paula Hawkins");
            Console.WriteLine("6- Ahmet Ümit                          15- Dan Brown");
            Console.WriteLine("7- Elif Şafak                          16- Josh Malerman ");
            Console.WriteLine("8- Zülfü Livaneli                      17- Antoine de Saint-Exupéry");
            Console.WriteLine("9- Oğuz Atay                           18- Nazım Hikmet");
        }
        public void buy()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("satın almak istediğiniz kitabın ismi?");
            Console.Write(">>>");
            string book = Console.ReadLine();
            switch (book)
            {
                case "kürk mantolu madonna":
                    Console.WriteLine("fee:42 TL");
                    Console.WriteLine("Please contact our employee");
                    break;
                case "çalıkuşu":
                    Console.WriteLine("fee:37TL");
                    Console.WriteLine("Please contact our employee");
                    break;
                case "yaprak dökümü":
                    Console.WriteLine("fee:78 TL");
                    Console.WriteLine("Please contact our employee");
                    break;
                case "suç ve ceza":
                    Console.WriteLine("fee:42 TL");
                    Console.WriteLine("Please contact our employee");
                    break;
                case "nutuk":
                    Console.WriteLine("fee:52 TL");
                    Console.WriteLine("Please contact our employee");
                    break;
                case "başlangıç":
                    Console.WriteLine("fee:44 TL");
                    Console.WriteLine("Please contact our employee");
                    break;
                case "trendeki kız":
                    Console.WriteLine("fee:42 TL");
                    Console.WriteLine("Please contact our employee");
                    break;
                case "kafes":
                    Console.WriteLine("fee:39 TL");
                    Console.WriteLine("Please contact our employee");
                    break;
                case "körlük":
                    Console.WriteLine("fee:12 TL");
                    Console.WriteLine("Please contact our employee");
                    break;
                case "istanbul hatırası":
                    Console.WriteLine("fee:27 TL");
                    Console.WriteLine("Please contact our employee");
                    break;
                case "aşk":
                    Console.WriteLine("fee:43 TL");
                    Console.WriteLine("Lütfen çalışanımızla iletişime geçin");
                    break;
                case "amok koşucusu":
                    Console.WriteLine("fee:57 TL");
                    Console.WriteLine("Lütfen çalışanımızla iletişime geçin");
                    break;
                case "bilinmeyen bir kadının mektubu":
                    Console.WriteLine("fee:32 TL");
                    Console.WriteLine("Lütfen çalışanımızla iletişime geçin");
                    break;
                case "satranç":
                    Console.WriteLine("fee:67 TL");
                    Console.WriteLine("Lütfen çalışanımızla iletişime geçin");
                    break;
                case "küçük prens":
                    Console.WriteLine("fee:87 TL");
                    Console.WriteLine("Lütfen çalışanımızla iletişime geçin");
                    break;
            }    
        }

    }
}
