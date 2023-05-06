using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_Intro_To_SE
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "SignUp";
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Flag = false;
            if (File.ReadAllLines("EmployeeIDs.txt").Contains(textBox1.Text))
            {
                Flag = true;
                label3.Hide();
            }
            else
            {
                textBox1.Text = "";
                label3.Show();
            }
            if(File.ReadAllLines("SignUpData.txt").Contains(textBox1.Text))
            {
                MessageBox.Show("This Id Already has an Account");
                this.Hide();
                Login open=new Login();
                open.FormClosed+=(s,args)=>this.Close();
                open.Show();
                Flag = false;
            }
            if(Flag)
            {
                this.Hide();
                SignUp2 Open = new SignUp2();
                Open.ID = textBox1.Text;
                Open.FormClosed += (s, args) => this.Close();
                Open.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PayMatic open = new PayMatic();
            this.Hide();
            open.FormClosed += (s, args) => this.Close();
            open.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
