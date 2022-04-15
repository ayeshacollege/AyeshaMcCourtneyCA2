using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyeshaMcCourtneyCA2
{
    public partial class FormDoctor : Form
    {
        List<ClassDoctor> classDoctorList = new List<ClassDoctor>();
        public FormDoctor()
        {
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            comboSpec.DataSource = Enum.GetValues(typeof(doc));
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            string sp = comboSpec.Text;

            Console.WriteLine("You are a" + sp + "doctor");

        }
    }
}
