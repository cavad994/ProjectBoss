using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS
{
    public class Worker
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Region { get; set; }
        public string? Number { get; set; }
        public int Age { get; set; }
        public CV? cv { get; set; }
        
        public Worker(int ıD, string? name, string? surname,
            string? region, string? number, int age, CV? cv)
        {
            ID = ıD;
            Name = name;
            Surname = surname;
            Region = region;
            Number = number;
            Age = age;
            this.cv = cv;
        }
    }
}
