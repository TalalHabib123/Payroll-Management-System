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
    public partial class EditLeaves : Form
    {
        public string EmployeeID;
        public EditLeaves()
        {
            InitializeComponent();
        }

        private void EditLeaves_Load(object sender, EventArgs e)
        {
            label5.Hide();
            label6.Hide();
            StreamReader sr = new StreamReader("EmployeeLeaves.txt");
            string temp1,temp2, temp3, temp4, temp5, temp6,temp7;
            temp1 = sr.ReadLine();
            temp2 = sr.ReadLine();
            temp3 = sr.ReadLine();
            temp4 = sr.ReadLine();
            temp5 = sr.ReadLine();
            temp6 = sr.ReadLine();
            temp7 = sr.ReadLine();
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
                temp5 = sr.ReadLine();
                temp6 = sr.ReadLine();
                temp7 = sr.ReadLine();
            }
            sr.Close();
            textBox1.Text = temp2;
            textBox2.Text = temp3;
            textBox3.Text = temp4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Flag = true;
            if (textBox1.Text =="" || textBox2.Text =="" || textBox3.Text=="")
            {
                label5.Show();
                Flag = false;
            }
            if(textBox1.Text.All(char.IsDigit)==false)
            {
                label6.Show();
                Flag = false;
            }
            if (textBox2.Text.All(char.IsDigit) == false)
            {
                label6.Show();
                Flag = false;
            }
            if (textBox3.Text.All(char.IsDigit) == false)
            {
                label6.Show();
                Flag = false;
            }
            if (Flag==true)
            {
                string[] Alllines = File.ReadAllLines("EmployeeLeaves.txt");
                int i = 0;
                for(;i<Alllines.Length;i++)
                {
                    if(Alllines[i] ==EmployeeID)
                    {
                        break;
                    }
                }
                Alllines[i + 1] = textBox1.Text;
                Alllines[i + 2] = textBox2.Text;
                Alllines[i + 3] = textBox3.Text;    
                File.WriteAllLines("EmployeeLeaves.txt",Alllines);
                MessageBox.Show("Leaves Updated");
                this.Close();
            }
        }
    }
}
