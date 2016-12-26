using System;
using System.Collections.Generic;
using System.Linq;
using Catdll;
using System.Text;
using System.Threading.Tasks;

namespace Catlab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Master = new Human("Чел");
            Cat Kosh = new Cat(Master);
            Console.Write("Введите имя кошки: ");
            Kosh.Name = Console.ReadLine();
            Console.Write("Обозначьте любимую игрушку: ");
            Kosh.LovelyToy = Console.ReadLine();
            Console.WriteLine("Возраст кошки: " + Kosh.Age);
            Kosh.Touch();
            Console.WriteLine("Любимая игрушка: " + Kosh.LovelyToy);
            Console.ReadKey();

        }
    }
}