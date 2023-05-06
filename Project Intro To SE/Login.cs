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
    public partial class Login : Form
    {
        public Login() // Constructor
        {
            InitializeComponent();
 
        }

        private void Login_Load(object sender, EventArgs e) //Load Login Page
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
            label2.Hide();
        }

        private void label1_Click(object sender, EventArgs e)// Useless
        {

        }

        private void label2_Click(object sender, EventArgs e)// Useless
        {

        }
        private void button1_Click(object sender, EventArgs e) // Check Login Info 
        {
            string UserEmail= textBox1.Text; // Store Username
            string UserPasswrord = textBox2.Text; // Store Password

            if(File.ReadAllLines("Admin.txt").Contains(UserEmail) && File.ReadAllLines("Admin.txt").Contains(UserPasswrord)) // Checking against Admin File
            {
                this.Hide();
                AdminDash open = new AdminDash();
                open.Closed += (s, args) => this.Close();
                open.Show();
            }

            string temp, temp1, temp2, temp3, temp4, temp5, temp6, temp7; 
            StreamReader sr = new StreamReader("SignUpData.txt");
            sr.BaseStream.Seek(0, SeekOrigin.Begin); // Reading Employee Info from File
            temp = sr.ReadLine();
            temp1 = sr.ReadLine();
            temp2 = sr.ReadLine();
            temp3 = sr.ReadLine();
            temp4 = sr.ReadLine();
            temp5 = sr.ReadLine();
            temp6 = sr.ReadLine();
            temp7 = sr.ReadLine();
            while (temp != null) // Read till end of file
            {
                if (temp4 == UserPasswrord) // user Password
                {
                    if(UserEmail==temp2  || UserEmail==temp ||UserEmail==temp3) //email, ID, Mobile No.
                    {
                        this.Hide();
                        Employee open = new Employee();
                        open.Closed += (s, args) => this.Close();
                        open.EmployeeID = temp;
                        open.LoginAdmin = false;
                        open.Show();
                    }
                }
                temp = sr.ReadLine();
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                temp3 = sr.ReadLine();
                temp4 = sr.ReadLine();
                temp5 = sr.ReadLine();
                temp6 = sr.ReadLine();
                temp7 = sr.ReadLine();
            }
            label2.Show(); // Error
            textBox1.Text = ""; 
            textBox2.Text = "";
            sr.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Opening Forget Password
        {
           
            this.Hide();
            ForgetPassword Open=new ForgetPassword();
            Open.FormClosed+=(s, args) => this.Close();
            Open.Show();
        }

        

        private void label6_Click(object sender, EventArgs e) // Useless
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) // Useless
        {

        }

        private void button2_Click(object sender, EventArgs e) // Back to homepage
        {
            PayMatic open=new PayMatic();
            this.Hide();
            open.FormClosed+=(s, args) => this.Close(); 
            open.Show();
        }
    }
}
