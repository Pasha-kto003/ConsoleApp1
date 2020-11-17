using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Animal
    {
        public DateTime BirthDay

        { get; set; }



        public int Age
        {
            set { }
            get { return (int)DateTime.Now.Subtract(BirthDay).TotalDays / 365; }
        }
    }
}
