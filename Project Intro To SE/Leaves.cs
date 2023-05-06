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
    public partial class Leaves : Form
    {
        public bool Admin;
        public string EmployeeID;
        public Leaves()
        {
            InitializeComponent();
        }

        private void Leaves_Load(object sender, EventArgs e)
        {
            if(Admin)
            {
                button1.Hide();
            }
            StreamReader sr = new StreamReader("EmployeeLeaves.txt");
            string temp1, temp2, temp3, temp4, temp5, temp6, temp7;
            temp1 = sr.ReadLine();
            temp2 = sr.ReadLine();
            temp3 = sr.ReadLine();
            temp4 = sr.ReadLine();
            temp5 = sr.ReadLine();
            temp6 = sr.ReadLine();
            temp7 = sr.ReadLine();
            while (temp1 != null)
            {
                if (temp1 == EmployeeID)
                {
                    break;
                }
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                temp3 = sr.ReadLine();
                temp4 = sr.ReadLine();
                temp5 = sr.ReadLine();
                temp6 = sr.ReadLine();
                temp7 = sr.ReadLine();
            }
            sr.Close();
            label10.Text = temp2;
            label11.Text = temp3;
            label12.Text = temp4;   
            label13.Text = temp5;   
            label14.Text = temp6;
            label15.Text = temp7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvailLeaves open = new AvailLeaves();
            open.EmployeeID = EmployeeID;
            open.FormClosed+=(s,args)=>this.Close();
            open.Show();
            //this.Show();
        }
    }
}
