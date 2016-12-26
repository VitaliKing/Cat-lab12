using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catdll
{
    public class Human
    {
        private string _name;

        public Human(string Name)
        {
            this.Name = Name;
        }

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
    }
}
