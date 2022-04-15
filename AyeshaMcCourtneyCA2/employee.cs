using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyeshaMcCourtneyCA2
{
    internal class employee : Person
    {
        private string na;
        private string ag;
        private string ad;
        private string cy;
        private string pno;
        private string em;
        private double empno;
        private string? phno;
        private string empl;

        public employee()
        {
        }

/*        public employee(string na, string ad, string cy, string ag, string phno, string em, string empl)
        {
            this.na = na;
            this.ad = ad;
            this.cy = cy;
            this.ag = ag;
            this.pno = phno;
            this.em = em;
            this.empl = empl;
        }
*/
        public employee(string na, string ag, string ad, string cy, string phno, string em, double empno, string empl)
        {
            this.na = na;
            this.ag = ag;
            this.ad = ad;
            this.cy = cy;
            this.pno = phno;
            this.em = em;
            this.empno = empno;
            this.empl = empl;
        }

        public double EmployeeNo { get; set; }

    }
}
