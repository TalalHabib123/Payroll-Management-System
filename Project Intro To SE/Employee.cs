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
    public partial class Employee : Form
    {
        public string EmployeeID;
        public bool LoginAdmin;
        public string name;
        public Employee()
        {
            InitializeComponent();
            LoginAdmin = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            GeneralInfo open=new GeneralInfo();
            open.EmployeeID = EmployeeID;
            open.Show();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendance open=new Attendance();
            //this.Hide();
            open.EmployeeID=EmployeeID;
            open.Show();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeeNews open=new EmployeeNews();   
            open.Show();
            this.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            label5.Text=EmployeeID;
            label3.Text = name;
            if(LoginAdmin==false)
            {
                string[] ReadFile = File.ReadAllLines("EmployeeData.txt");
                int i = 0;
                for(i=0;i<ReadFile.Length;i++)
                {
                    if(ReadFile[i] == EmployeeID)
                    {
                        break;
                    }
                }
                label3.Text = ReadFile[i + 1];
                name=ReadFile[i+1];
            }
            if (LoginAdmin==true)
            {
                button6.Text = "Back to Dashboard";
                button5.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(LoginAdmin==true)
            {
                this.Close();
            }
            else
            {
                this.Hide();
                Login open = new Login();
                open.FormClosed += (s, args) => this.Close();
                open.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalarySlip open=new SalarySlip();
            open.EmployeeID = EmployeeID;
            open.EmployeeName = name;
            open.Show();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leaves open=new Leaves();
            open.Admin = LoginAdmin;
            open.EmployeeID = EmployeeID;
            open.Show();
            this.Show();
        }
    }
}
