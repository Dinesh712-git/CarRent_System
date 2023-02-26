using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentCar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Carbtn_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.Show();
            this.Hide();
        }

        private void Customerbtn_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
            this.Hide();
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Show();
            this.Hide();
        }

        private void rentalbtn_Click(object sender, EventArgs e)
        {
            Rental r = new Rental();
            r.Show();
            this.Hide();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            Return re = new Return();
            re.Show();
            this.Hide();

        }

        private void dashboadbtn_Click(object sender, EventArgs e)
        {
            Dashboad d = new Dashboad();
            d.Show();
            this.Hide();
        }
    }
}
