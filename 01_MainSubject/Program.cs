using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            // Console.WriteLine("selam");
            //Console.Write("merhaba dünya");
            #endregion

            #region StringDeğişkenler
            /*
            string name;
            name = "Ayşenur";
            Console.WriteLine(name);
            
            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;
            

            customerName = "Ayşenur";
            customerSurname = "Yeşil";
            customerPhone = "5385400211";
            customerEmail = "deneme@gmail.com";
            district = "Efeler";
            city = "Aydın";

            Console.WriteLine("*****REZERVASYON KARTI*****");
            Console.WriteLine();
            Console.WriteLine("*******************************************");
            Console.WriteLine("Müşteri: "+ customerName+ " "+customerSurname);
            Console.WriteLine("İletişim: "+ customerPhone);
            Console.WriteLine("Mail: "+customerEmail);
            Console.WriteLine("Adres: "+ district+"/"+city);
            Console.WriteLine("*******************************************");

            Console.WriteLine() ;

            customerName = "Barış Alper";
            customerSurname = "Yılmaz";
            customerPhone = "5378544129";
            customerEmail = "denemegsgs@gmail.com";
            district = "Çayeli";
            city = "Rize";

            Console.WriteLine("*******************************************");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Mail: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("*******************************************");
            
            */
            #endregion

            #region IntDeğişkenler
            int hamburgerPrice =250;
            int pizzaPrice = 150;
            int waterPrice = 10;
            int colaPrice=30;

            Console.WriteLine("****Restoran Menü Fiyatı****");
            Console.WriteLine();
            Console.WriteLine("--Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("--Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("--Su Fiyatı: " + waterPrice + " TL");
            Console.WriteLine("--Cola Fiyatı: " + colaPrice + " TL");
            Console.WriteLine("*****************************");
            Console.WriteLine();

            int hamburgerCount = 4;
            int pizzaCount = 1;
            int waterCount = 2;
            int colaCount = 2;


            int totalHamburgerPrice= hamburgerPrice*hamburgerCount;
            int totalPizzaPrice=pizzaPrice*pizzaCount;
            int totalWaterPrice=waterPrice*waterCount;
            int totalColaPrice=colaPrice*colaCount;

            Console.WriteLine("*******************************");

            Console.WriteLine("Toplam Hamburger Fiyatı:"+totalHamburgerPrice+" TL");
            Console.WriteLine("Toplam Pizza Fiyatı:" + totalPizzaPrice + " TL");
            Console.WriteLine("Toplam Su Fiyatı:" + totalWaterPrice + " TL");
            Console.WriteLine("Toplam Cola Fiyatı:" + totalColaPrice + " TL");
            int totalPrice=totalHamburgerPrice*totalPizzaPrice+totalColaPrice+totalWaterPrice;
            Console.WriteLine("Toplam Ödenecek Tutar:"+totalPrice+" TL");
            #endregion

            Console.Read();
        }
    }
}
