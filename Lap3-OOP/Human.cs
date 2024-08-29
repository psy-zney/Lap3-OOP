using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3_OOP
{
    public class Human
    {
        public string Name { get; set; }
        public int age { get; set; }    
    }
    public class Employee : Human
    {
        public float coef { get; set; }
        public int numOfChild { get; set; }
        public double Caculatery ()
        {
        return coef* 3200000 + numOfChild* 300000 ;
            }
    }
}
