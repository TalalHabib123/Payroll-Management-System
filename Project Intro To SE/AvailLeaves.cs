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
    public partial class AvailLeaves : Form
    {
        public string EmployeeID;
        public AvailLeaves()
        {
            InitializeComponent();
        }

        private void AvailLeaves_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Flag = true;
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
            if(radioButton1.Checked==true)
            {
                if (Convert.ToInt32(temp2) <= Convert.ToInt32(temp5))
                {
                    Flag = false;
                    label3.Show();
                }
                else
                {
                    int i = Convert.ToInt32(temp5);
                    i++;
                    temp5=i.ToString();
                }
            }
            if(radioButton2.Checked==true)
            {
                if (Convert.ToInt32(temp3) <= Convert.ToInt32(temp6))
                {
                    Flag = false;
                    label3.Show();
                }
                else
                {
                    int i = Convert.ToInt32(temp6);
                    i++;
                    temp6 = i.ToString();
                }
            }
            if(radioButton3.Checked==true)
            {
                if (Convert.ToInt32(temp4) <= Convert.ToInt32(temp7))
                {
                    Flag = false;
                    label3.Show();
                }
                else
                {
                    int i = Convert.ToInt32(temp7);
                    i++;
                    temp7 = i.ToString();
                }

            }
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked==false)
            {
                label2.Show();
            }
            if (Flag == true)
            {
                label2.Hide();
                label3.Hide();
                string[] Alllines = File.ReadAllLines("EmployeeLeaves.txt");
                int i = 0;
                for (; i < Alllines.Length; i++)
                {
                    if (Alllines[i] == EmployeeID)
                    {
                        break;
                    }
                }
                Alllines[i + 4] = temp5;
                Alllines[i + 5] = temp6;
                Alllines[i + 6] = temp7;
                File.WriteAllLines("EmployeeLeaves.txt", Alllines);
                MessageBox.Show("Leaves Updated");
                this.Close();
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true &&radioButton2.Checked==true)
            {
                radioButton2.Checked=false;
            }
            if (radioButton1.Checked == true && radioButton3.Checked == true)
            {
                radioButton3.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked == true && radioButton3.Checked == true)
            {
                radioButton3.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton3.Checked == true)
            {
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked == true && radioButton3.Checked == true)
            {
                radioButton2.Checked = false;
            }
        }
    }
}
