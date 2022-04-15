namespace AyeshaMcCourtneyCA2
{
    public partial class dgv : Form
    {
        public dgv()
        {
            InitializeComponent();
        }

            MyListView mlv  = new MyListView();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboCounty.DataSource = Enum.GetValues(typeof(counties));
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string na = TxtName.Text;

            string ag = TxtAge.Text;

            string ad = TxtAddress.Text;

            string cy = ComboCounty.Text;

            string pno = TXTPhoneNo.Text;

            string em = TxtEmail.Text;
            
            mlv.AddToList(na, ag, ad, cy, pno, em);
           
            LstDisplay.Items.Clear();

            foreach (Person p in mlv.MyList)
            {
                LstDisplay.Items.Add(p.MyString());
            }

            dataGridView.DataSource = false;
            dataGridView.DataSource = mlv.MyList;

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtAddress.Clear();
            TxtAge.Clear();
            TxtEmail.Clear();
            TXTPhoneNo.Clear();
        }

        private void btneEmployee_Click(object sender, EventArgs e)
        {
            FormEmployee ae = new FormEmployee();
            ae.Show(); 
        }

        private void ComboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            FormEmployee ae = new FormEmployee();
            ae.Show();
        }

        private void LstDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}