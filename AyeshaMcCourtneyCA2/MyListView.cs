using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyeshaMcCourtneyCA2
{
    internal class MyListView
    {
       public List<Person> MyList = new List<Person>();
       public List<employee> MyEmpList = new List<employee>();


        public void AddToList(string na, string ad, string cy, string ag, string pno, string em)
        {
            Person p = new Person();
            p.Name = na;
            p.address = ad;
            p.county = cy;
            p.Age = ag;
            p.number = pno;
            p.email = em;
           


            MyList.Add(p);
        }

        public void EmpToList(string na, string ag, string ad, string cy, string phno, string em, double empno, string empl)
        {
            employee ex = new employee();
            ex.Name = na;
            ex.address = ad;
            ex.county = cy;
            ex.Age = ag;
            ex.number = phno;
            ex.email = em;
            ex.specialty = empl;

/*

            MyEmpList.Add(ex);*/
        }


    }
}
