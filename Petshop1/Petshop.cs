using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    class Petshop
    {
        CatHouse[] CatHouses { set; get; }
        public int CatHouseCount { get; set; } = 0;
        public void AddCatHouse(ref CatHouse catHouse)
        {
            CatHouse[] temp = new CatHouse[++CatHouseCount];
            if (CatHouses != null)
            {
                CatHouses.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = catHouse;
            CatHouses = temp;
        }
        public void ShowPetShop()
        {
            foreach (var item in CatHouses)
            {
                item.ShowCats();
            }
        }

    }
}
