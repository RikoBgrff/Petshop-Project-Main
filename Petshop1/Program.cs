using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{

    class Program
    {
        //Pishiklerle 2 cur oynamaq mumkundur. 0-sizin uchun trikler gosterir,1-sizinle gizlen qach oynayir
        //pishik size gosterdiyi her trik uchun 2 enerji itirir,gizlen qachda ise 10 enerji itirir
        //pishiklerin enerjileri,qiymetleri levele esasen deyishir.
        //Pishiyi yatizdirmaq uchun deqiqe gondermek lazimdir,gonderilen deqiqeye esasen pishik yatir ve deqiqeye uygun olaraq enerji toplayir
        //Pishiyi yedizdirmek uchun yemek miqdarini qeyd etmek lazimdir,Pishiyin yigacagi enerji levellere gore deyisir.
        //Pishik evine pishik elave etmek,onlara nezaret etmek mumkundur
        //Heyvan magazasinda pishik evlerine ve onlarin ichindeki pishiklere baxmaq ve magazaya pishik evi elave etmek mumkundur
        static void Main(string[] args)
        {
            //Pishiklerin Yaradilmasi
            Cat cat = new Cat("Jane", 1, "Female", 1);
            Cat cat2 = new Cat("Poppy", 2, "Female", 2);
            Cat cat3 = new Cat("Jack", 2, "Male", 3);
            Cat cat4 = new Cat("Kate", 3, "Female", 3);
            //Pishik evinin yaradilmasi
            CatHouse catHouse1 = new CatHouse();
            CatHouse catHouse2 = new CatHouse();
            //Pishiklerin pishik evine elave edilmesi
            catHouse1.AddCat(ref cat);
            catHouse1.AddCat(ref cat2);
            catHouse2.AddCat(ref cat3);
            catHouse2.AddCat(ref cat4);
            //Pishik evindeki pishikleri gormek
            //catHouse1.ShowCats();
            //Heyvan Magazasinin yaradilmasi
            Petshop petshop = new Petshop();
            //Pishik evinin magazaya elave edilmesi
            petshop.AddCatHouse(ref catHouse1);
            petshop.AddCatHouse(ref catHouse2);
            //Magazadaki pishik evlerini gormek
            petshop.ShowPetShop();
            //Pishikle gizlen qac oynamaq

            //cat.Play(1);

            //Pishiyi yatizdirmaq

            //cat.Sleep(2);

            //Pishiyi yedizdirmek

            //cat.Eat(1);

            Console.ReadLine();

        }
    }
}
