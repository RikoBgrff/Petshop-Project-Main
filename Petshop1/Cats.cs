using System;
using System.Threading;

namespace Petshop
{
    class Cat
    {

        private string nickname;
        public string Nickname
        {
            get { return nickname; }
            set
            {
                if (string.IsNullOrEmpty(nickname))
                {
                    nickname = value;
                }
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (age == 0) { age = value; }
            }
        }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (String.IsNullOrEmpty(gender))
                {
                    gender = value;
                }
            }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (price == 0)
                {
                    price = value;
                }
            }
        }

        private int mealQuantity;
        public int MealQuantity
        {
            get { return mealQuantity; }
            set
            {
                if (mealQuantity <= 0)
                {
                    mealQuantity = value;
                }
            }
        }

        private int energy;
        public int Energy
        {
            get { return energy; }
            set
            {
                if (energy >= 0)
                {
                    energy = value;
                }
            }
        }
        private int level;
        public int Level
        {
            get { return level; }
            set
            {
                if (level <= 0 && 3 >= level)
                {
                    level = value;
                    if (level == 1)
                    {
                        Price = 10;
                        Energy = 30;
                    }
                    else if (level == 2)
                    {
                        Price = 20;
                        Energy = 60;
                    }
                    else if (level == 3)
                    {
                        Price = 30;
                        Energy = 90;
                    }
                }
            }
        }

        public Cat(string nickname, int age, string gender, int level)
        {
            Nickname = nickname;
            Age = age;
            Gender = gender;
            Level = level;
        }


        public void Sleep(int minute)
        {
            if (Level == 1)
            {
                if (minute > 10)
                {
                    minute = 10;
                    Console.WriteLine($"{Nickname} is sleeping now");
                    int millisecond = minute * 1000;
                    Thread.Sleep(millisecond);
                    Energy = minute * 3;
                    if (Energy > 30)
                    {
                        Energy = 30;
                    }
                }
            }
            if (Level == 2)
            {
                if (minute > 10)
                {
                    minute = 10;
                    Console.WriteLine($"{Nickname} is sleeping now");
                    int millisecond = minute * 1000;
                    Thread.Sleep(millisecond);
                    Energy = minute * 6;
                    if (Energy > 60)
                    {
                        Energy = 60;
                    }
                }
            }
            if (Level == 3)
            {
                if (minute > 10)
                {

                    minute = 10;
                    Console.WriteLine($"{Nickname} is sleeping now");
                    int millisecond = minute * 1000;
                    Thread.Sleep(millisecond);
                    Energy = minute * 12;
                    if (Energy > 90)
                    {
                        Energy = 90;
                    }
                }
            }
        }
        public void Play(int trickOrFreePlay)
        {
            if (trickOrFreePlay == 0)//trick
            {
                if (Energy > 2)
                {
                    Console.WriteLine("Funny Trick");
                    Console.WriteLine($"energy:{Energy}");
                    int v = Energy - 2;
                    Energy = v;
                    Console.WriteLine($"energy:{Energy}");
                }
                else if (Energy <= 1)
                {
                    Energy = 0;
                    Sleep(10);
                }

            }
            if (trickOrFreePlay == 1)//freeplay
            {
                if (Energy > 10)
                {
                    Console.WriteLine($"Hello my name is {Nickname}");
                    Thread.Sleep(2000);
                    Console.WriteLine("What we can do,let me think");
                    Thread.Sleep(2000);
                    Console.WriteLine("I found! We will play Hide and Seek");
                    Thread.Sleep(2000);
                    Console.WriteLine("While i count till 10 you must hide somewhere");
                    Thread.Sleep(2000);
                    Console.WriteLine("When i will say 10, i'll start to search for you");
                    Thread.Sleep(1000);
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.Write($" {i}");
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine("\nMeow,meow where are youu");
                    Thread.Sleep(1000);
                    Console.WriteLine("I see youuuu");
                    Thread.Sleep(1000);
                    Console.WriteLine("I found you");
                    Thread.Sleep(1000);
                    Console.WriteLine($"energy:{Energy}");
                    Energy = Energy - 10;
                    Console.WriteLine($"energy:{Energy}");
                }
                else if (Energy <= 10)
                {

                    Sleep(10);
                }

            }

            if (Energy == 0)
            {
                Sleep(1);
            }
        }
        public void Eat(int azn)
        {
            if (Level == 1)
            {
                if (azn == 1)
                {
                    MealQuantity = 1;
                    Energy = Energy + 6;
                    if (Energy > 30)
                    {
                        Energy = 30;
                    }
                }
                if (azn == 2)
                {
                    MealQuantity = 2;
                    Energy = Energy + 12;
                    if (Energy > 30)
                    {
                        Energy = 30;
                    }
                }
                if (azn == 3)
                {
                    MealQuantity = 3;
                    Energy = Energy + 18;
                    if (Energy > 30)
                    {
                        Energy = 30;
                    }
                }
                if (azn == 4)
                {
                    MealQuantity = 4;
                    Energy = Energy + 24;
                    if (Energy > 30)
                    {
                        Energy = 30;
                    }
                }
                if (azn == 5)
                {
                    if (Energy == 0)
                    {
                        MealQuantity = 5;
                        Energy = Energy + 30;
                        if (Energy > 30)
                        {
                            Energy = 30;
                        }
                    }
                    if (Energy != 0)
                    {
                        PaymentExceptionClass payment = new PaymentExceptionClass("You can not pay 5 AZN for cat if he\\she has more energy than 0");
                        throw payment;
                    }
                }
            }
            if (Level == 2)
            {
                if (azn == 1)
                {
                    MealQuantity = 1;
                    Energy = Energy + 36;
                    if (Energy > 60)
                    {
                        Energy = 60;
                    }
                }
                if (azn == 2)
                {
                    MealQuantity = 2;
                    Energy = Energy + 42;
                    if (Energy > 60)
                    {
                        Energy = 60;
                    }
                }
                if (azn == 3)
                {
                    MealQuantity = 3;
                    Energy = Energy + 48;
                    if (Energy > 60)
                    {
                        Energy = 60;
                    }
                }
                if (azn == 4)
                {
                    MealQuantity = 4;
                    Energy = Energy + 54;
                    if (Energy > 60)
                    {
                        Energy = 60;
                    }
                }
                if (azn == 5)
                {
                    if (Energy == 0)
                    {
                        MealQuantity = 5;
                        Energy = Energy + 60;
                        if (Energy > 60)
                        {
                            Energy = 60;
                        }
                    }
                    if (Energy != 0)
                    {
                        PaymentExceptionClass payment = new PaymentExceptionClass("You can not pay 5 AZN for cat if he\\she has more energy than 0");
                        throw payment;
                    }
                }
            }
            if (Level == 3)
            {
                if (azn == 1)
                {
                    MealQuantity = 1;
                    Energy = Energy + 66;
                    if (Energy > 90)
                    {
                        Energy = 90;
                    }
                }
                if (azn == 2)
                {
                    MealQuantity = 2;
                    Energy = Energy + 72;
                    if (Energy > 90)
                    {
                        Energy = 90;
                    }
                }
                if (azn == 3)
                {
                    MealQuantity = 3;
                    Energy = Energy + 78;
                    if (Energy > 90)
                    {
                        Energy = 90;
                    }
                }
                if (azn == 4)
                {
                    MealQuantity = 4;
                    Energy = Energy + 84;
                    if (Energy > 90)
                    {
                        Energy = 90;
                    }
                }
                if (azn == 5)
                {
                    if (Energy == 0)
                    {
                        MealQuantity = 5;
                        Energy = Energy + 90;
                        if (Energy > 90)
                        {
                            Energy = 90;
                        }
                    }
                    if (Energy != 0)
                    {
                        PaymentExceptionClass payment = new PaymentExceptionClass("You can not pay 5 AZN for cat if he\\she has more energy than 0");
                        throw payment;
                    }
                }
            }

        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=========CAT==========");
            Console.WriteLine($"Nickname:{Nickname}");
            Console.WriteLine($"Gender:{Gender}");
            Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"Level:{Level}");
            Console.WriteLine($"Energy:{Energy}");
            Console.WriteLine($"Price:{Price}");
        }
    }
}

