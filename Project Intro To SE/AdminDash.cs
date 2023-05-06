using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Intro_To_SE
{
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }

        private void AdminDash_Load(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Visible = true;
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            panel4.Controls.Add(adminHome);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Visible = true;
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            panel4.Controls.Add(adminHome);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Visible = true;
            EmployeeData Data_Employee= new EmployeeData();
            Data_Employee.Show();
            panel4.Controls.Add(Data_Employee);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Visible = true;
            News Data_News = new News();
            Data_News.Show();
            panel4.Controls.Add(Data_News);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Visible = true;
            Business Data_News = new Business();
            Data_News.Show();
            panel4.Controls.Add(Data_News);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Visible = true;
            About Data_News = new About();
            Data_News.Show();
            panel4.Controls.Add(Data_News);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login open=new Login();   
            open.FormClosed+=(s,args)=>this.Close();
            open.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
