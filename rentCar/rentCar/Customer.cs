using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace rentCar
{
    public partial class Customer : Form
    {
        MySqlConnection con = new MySqlConnection(
      "server=localhost;userid = root; password=;database=CARrent;  ");
        public Customer()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // textBox1.Text = "you are now connect database";
                MySqlCommand sm = new MySqlCommand("select * from customer", con);


                MySqlDataAdapter da = new MySqlDataAdapter(sm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                sm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
