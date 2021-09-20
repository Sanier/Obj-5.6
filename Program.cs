using System;

namespace Obj_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static (string Name, string LastName, int Age, bool HasPet, string[] Pets, byte colors) EnterUser()
        {
            (string Name, string LastName, int Age, bool HasPet) User;

            Console.WriteLine("Введите свое имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию");
            User.LastName = Console.ReadLine();

            string age;
            int intage;

            do
            {
                Console.WriteLine("Введите свой возраст цифрами");
                age = Console.ReadLine();

            } while (CheckNum(age, out intage));

            User.Age = intage;

            Console.WriteLine("Есть у вас питомец?");
            string pet = Console.ReadLine();
            string numpets;
            if (pet == "Да")
            {
                User.HasPet = true;

                Console.WriteLine("Сколько у вас питомцев?");
                numpets = Console.ReadLine();
            }
            else
            {
                User.HasPet = false;
            }
            
            return User;

        }

        static string[] CreateArrayPets(int num)
        {
            var result = new string[num];

        }

        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if(intnum > 0)
                {
                    corrnumber = intnum;
                    return true;
                }
            }
            else
            {
                corrnumber = 0;
                return false;
            }
        }
    }
}
