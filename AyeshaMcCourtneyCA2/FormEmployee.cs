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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        List<employee> MyEmp = new List<employee>();
        MyListView mlv = new MyListView();

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string na = TxtName.Text;

            string ag = TxtAge.Text;

            string ad = TxtAddress.Text;

            string cy = ComboCounty.Text;

            string pno = TXTPhoneNo.Text;

            string em = TxtEmail.Text;

            string empl = comboEmployee.Text;

            double empno = double.Parse(txtEmpno.Text);

            employee emp = new employee(na, ag, ad, cy, pno, em, empno, empl);
            
            
            foreach (employee ex in mlv.MyEmpList)
            {
                LstDisplay.Items.Add(ex.MyString2());
            }

            if (comboEmployee.SelectedIndex == 0)
            {
                FormDoctor ae = new FormDoctor();
                ae.Show();
            }
            if (comboEmployee.SelectedIndex == 2)
            {
                FormPT ae = new FormPT();
                ae.Show();
            }
            if (comboEmployee.SelectedIndex == 11) 
            {

            }
            else if(comboEmployee.SelectedIndex == 3)
            {

            }

      
            LstDisplay.Items.Clear();
            foreach(employee ex in mlv.MyEmpList)
            {
                LstDisplay.Items.Add(ex.MyString2());
            }

            dataGridView.DataSource = false;
            dataGridView.DataSource = mlv.MyEmpList;

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtAddress.Clear();
            TxtAge.Clear();
            TxtEmail.Clear();
            TXTPhoneNo.Clear();
            txtEmpno.Clear();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            ComboCounty.DataSource = Enum.GetValues(typeof(counties));
            comboEmployee.DataSource = Enum.GetValues(typeof(job));
        }

        private void ComboDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
