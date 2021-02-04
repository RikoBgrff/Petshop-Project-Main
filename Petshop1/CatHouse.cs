using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    class CatHouse
    {
        public Cat[] Cats { get; set; }
        public int CatCount { get; set; } = 0;
        public void AddCat(ref Cat cat)
        {
            Cat[] temp = new Cat[++CatCount];
            if (Cats != null)
            {
                Cats.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = cat;
            Cats = temp;
        }
        //public void RemoveByNickname(string nickname)
        //{
        //    foreach (var item in Cats)
        //    {
        //        if(nickname == item.Nickname)
        //        {

        //        }
        //    }
        //}
        public void ShowCats()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======CAT HOUSE=======");
            if (Cats != null)
            {
                foreach (var item in Cats)
                {
                    item.Show();
                }
            }
            Console.WriteLine($"Count of Cats:{CatCount}");
        }
        public void ShowCatNames()
        {
            foreach (var item in Cats)
            {
                Console.WriteLine(item.Nickname);
            }
        }
    }
}
