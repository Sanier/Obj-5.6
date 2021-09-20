using System;

namespace Obj_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterUser();
        }

        static (string Name, string LastName, int Age, bool HasPet, byte colors) EnterUser()
        {
            (string Name, string LastName, int Age, bool HasPet, byte colors) User;

            Console.WriteLine("Введите свое имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию");
            User.LastName = Console.ReadLine();

            string age;
            int intage = 0;

            do
            {
                Console.WriteLine("Введите свой возраст цифрами");
                age = Console.ReadLine();

            } while (CheckNum(age, out intage));

            User.Age = intage;

            Console.WriteLine("Есть у вас питомец?");
            string pet = Console.ReadLine();
            int numpets;
            if (pet == "Да")
            {
                User.HasPet = true;

                Console.WriteLine("Сколько у вас питомцев?");
                numpets = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите имена своих питомцев");
                CreateArrayPets(numpets);
            }
            else
            {
                User.HasPet = false;
            }

            Console.WriteLine("Введите количество любимых цветов цифрами");
            User.colors = byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите наименования своих любимых цветов");
            Favcolors(User.colors);
            return User;

        }

        static string[] CreateArrayPets(int num)
        {
            var result = new string[num];

            for (int i = 0; i < num; i++)
            {
                result[i] = Console.ReadLine();
            }

            return result;
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

        static string[] Favcolors(byte num)
        {
            var colors = new string[num];

            for (int i = 0; i < num; i++)
            {
                colors[i] = Console.ReadLine();
            }
            return colors;
        }
    }
}
