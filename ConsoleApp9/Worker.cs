using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public struct Characteristics
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public double Time { get; set; }
    }
    public class Worker
    {
        public Characteristics work = new Characteristics();
       
    }
}
