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
    public partial class EditSalary : Form
    {
        public string EmployeeID;
        public EditSalary()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EditSalary_Load(object sender, EventArgs e)
        {
            label3.Hide();
            label5.Hide();
            StreamReader sr = new StreamReader("Salary.txt");
            string temp1, temp2, temp3, temp4;
            temp1 = sr.ReadLine();
            temp2 = sr.ReadLine();  
            temp3 = sr.ReadLine();
            temp4= sr.ReadLine();
            while(temp1!=null)
            {
                if(temp1==EmployeeID)
                {
                    break;
                }
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                temp3 = sr.ReadLine();
                temp4 = sr.ReadLine();
            }
            sr.Close();
            textBox1.Text = temp2;
            textBox3.Text = temp3;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Flag = true;
            if(textBox1.Text=="" || textBox3.Text=="")
            {
                label3.Show();
                Flag = false;
            }
            if(textBox1.Text.All(char.IsDigit)==false)
            {
                Flag=false;
                label5.Show();
            }
            if (textBox3.Text.All(char.IsDigit) == false)
            {
                Flag = false;
                label5.Show();
            }
            if (Flag==true)
            {
                label3.Hide();
                label5.Hide();
                string[] AllLines = File.ReadAllLines("Salary.txt");
                int i = 0;
                for(;AllLines.Length>i;i++)
                {
                    if(AllLines[i]==EmployeeID)
                    {
                        break;
                    }
                }
                int s = (Convert.ToInt32(textBox1.Text))-(Convert.ToInt32(textBox3.Text));
                AllLines[i + 1] = textBox1.Text;
                AllLines[i + 2] = textBox3.Text;
                AllLines[i + 3] = s.ToString();
                File.WriteAllLines("Salary.txt",AllLines);
                MessageBox.Show("Salary Updated");
                this.Close();
            }
        }
    }
}
