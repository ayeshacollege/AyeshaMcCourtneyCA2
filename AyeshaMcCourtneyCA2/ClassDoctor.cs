using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyeshaMcCourtneyCA2
{
    internal class ClassDoctor : Form
    {
        public string? specialty { get; set; }
        private string sp;

        public ClassDoctor(string na, string ad, string cy, string ag, string phno, string em, string empl, string sp)
        {
            this.specialty = sp;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ClassDoctor
            // 
            this.ClientSize = new System.Drawing.Size(805, 710);
            this.Name = "ClassDoctor";
            this.ResumeLayout(false);

        }
    }
}
