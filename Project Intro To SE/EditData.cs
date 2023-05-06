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
    public partial class EditData : Form
    {
        public string EmployeeID;
        public EditData()
        {
            InitializeComponent();
        }

        private void EditData_Load(object sender, EventArgs e)
        {
            label6.Hide();
            StreamReader sr = new StreamReader("EmployeeData.txt");
            string temp1, temp2, temp3, temp4, temp5, temp6, temp7, temp8, temp9;
            temp1 = sr.ReadLine();
            temp2 = sr.ReadLine();
            temp3 = sr.ReadLine();
            temp4 = sr.ReadLine();
            temp5 = sr.ReadLine();
            temp6 = sr.ReadLine();
            temp7 = sr.ReadLine();
            temp8 = sr.ReadLine();
            temp9 = sr.ReadLine();
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
                temp8 = sr.ReadLine();
                temp9 = sr.ReadLine();
            }
            sr.Close();
            textBox1.Text = temp2;
            textBox2.Text = temp3;
            textBox3.Text = temp4;
            textBox4.Text = temp9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if(textBox4.Text=="" ||textBox1.Text=="" ||textBox2.Text=="" ||textBox3.Text=="")
            {
                label6.Show();
                flag = false;
            }
            if(flag==true)
            {
                StreamReader sr = new StreamReader("EmployeeData.txt");
                string temp1, temp2, temp3, temp4, temp5, temp6, temp7, temp8, temp9;
                temp1 = sr.ReadLine();
                temp2 = sr.ReadLine();
                temp3 = sr.ReadLine();
                temp4 = sr.ReadLine();
                temp5 = sr.ReadLine();
                temp6 = sr.ReadLine();
                temp7 = sr.ReadLine();
                temp8 = sr.ReadLine();
                temp9 = sr.ReadLine();
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
                    temp8 = sr.ReadLine();
                    temp9 = sr.ReadLine();
                }
                sr.Close();
                string File_Read = File.ReadAllText("EmployeeData.txt");
                File_Read = File_Read.Replace(temp2, textBox1.Text);
                File_Read = File_Read.Replace(temp3, textBox2.Text);
                File_Read = File_Read.Replace(temp4, textBox3.Text);
                File_Read = File_Read.Replace(temp9, textBox4.Text);
                File.WriteAllText("EmployeeData.txt", File_Read);
                MessageBox.Show("Data Changed");
                this.Close();
            }
        }
    }
}
