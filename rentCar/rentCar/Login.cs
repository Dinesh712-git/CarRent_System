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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if(UserIDtxbox.Text=="Dinesh"&&Passwordtxbox.Text=="di123")
            {
                Dashboad d = new Dashboad();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect UserID or Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            UserIDtxbox.Text = null;
            Passwordtxbox.Text = null;
        }

        private void quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
