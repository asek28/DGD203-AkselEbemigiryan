using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Player(string name = "Andrew", int age = 15) 
        {
            Name = name;
            Age = age;
        }

        public void Initialize(string name, int age) 
        {
            Name = name;
            Age = age;
        }
    }
}
