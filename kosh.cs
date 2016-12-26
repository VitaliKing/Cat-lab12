using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catdll
{
    public class Cat
    {
        private readonly DateTime _birhtday = DateTime.Now;
        private string _name;

        public Human Master { get; }

        private Cat() { }

        public Cat(Human Master) { this.Master = Master; } 
        public string Name
          {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }

        public int Age
        {
            get
            { return (DateTime.Now.Second - _birhtday.Second); }
        }

        public string LovelyToy { get; set; }

        public void Touch()
        {
            Random Ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                int g = Ran.Next(0, 2);
                if (g == 1)
                    May();
                else
                    Ykys();
            }

        }
        private void May()
        {
            Console.WriteLine("Вы гладите кошку. В ответ на ваши действия " + Name + " мяукает");
        }
        private void Ykys()
        {
            Console.WriteLine("Вы гладите кошку. В ответ на ваши действия " + Name + " кусает вас");
        }
    }
}