using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyeshaMcCourtneyCA2
{
    internal class Person
    {
        public string? Name { get; set; }
        public string? Age { get; set; }
        public string? email { get; set; }
        public string? address { get; set; }
        public string? county { get; set; }
        public string? number { get; set; }
        public string? emp { get; set; }
        public string? hour { get; set; }
        public string? specialty { get; set; }

        public string MyString()
        {
            return Name + " " + address + " " + county + " " + number + "+353 " + Age + " " + email + " ";
        }

        public string MyString2()
        {
            return Name + " " + address + " " + county + " " + number + "+353 " + Age + " " + email + " " + specialty + "";
        }

    }
}
