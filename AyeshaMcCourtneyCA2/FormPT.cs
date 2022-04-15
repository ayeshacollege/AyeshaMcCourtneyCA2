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
    public partial class FormPT : Form
    {
        List<FormPT> Pt = new List<FormPT>();
        public FormPT()
        {
            InitializeComponent();
        }

        private void FormPT_Load(object sender, EventArgs e)
        {
            string hr = TxtHr.Text;
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            

        }
    }
}
