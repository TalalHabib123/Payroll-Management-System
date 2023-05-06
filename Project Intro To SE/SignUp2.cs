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
    public partial class SignUp2 : Form
    {
        public string ID;
        public SignUp2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SignUp2_Load(object sender, EventArgs e)
        {
            label18.Text = ID;
            label14.Hide();
            label15.Hide();
            label16.Hide();
            label19.Hide();
        }

        public void WriteTOFile()
        {
            FileStream fs = new FileStream("SignUpData.txt", FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                string firstname = textBox1.Text;
                string second = textBox2.Text;
                string email = textBox3.Text;
                string mobile = textBox4.Text;
                string address = textBox5.Text;
                string passwrod = textBox6.Text;
                string date = comboBox1.Text;
                string month = comboBox2.Text;
                string year = comboBox3.Text;
                string gender = "";
                if (radioButton1.Checked == true)
                {
                    gender = "Male";
                }
                if (radioButton2.Checked == true)
                {
                    gender = "Female";
                }
                sw.WriteLine(ID);
                sw.WriteLine(firstname + " " + second);
                sw.WriteLine(email);
                sw.WriteLine(mobile);
                sw.WriteLine(passwrod);
                sw.WriteLine(date + "-" + month + "-" + year);
                sw.WriteLine(gender);
                sw.WriteLine(address);
            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            bool Flag = true;
            label14.Hide();
            label15.Hide();
            label16.Hide();
            label19.Hide();
            if (!(textBox6.Text.Length >= 8 && textBox6.Text.Length <= 15))
            {
                label19.Show();
                Flag = false;
            }
            if(radioButton2.Checked==false && radioButton1.Checked==false)
            {
                label14.Show();
                Flag = false;
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                label14.Show();
                Flag=false;
            }
            if(comboBox1.SelectedItem==null ||comboBox2.SelectedItem==null ||comboBox3.SelectedItem==null)
            {
                label14.Show();
                Flag = false;
            }
            if(!(textBox3.Text.Contains("@")&&textBox3.Text.Contains(".com")))
            {
                label15.Show();
                Flag = false;
            }
            if(!(textBox4.Text.All(char.IsDigit)))
            {
                label16.Show();
                Flag = false;
            }

            if (textBox7.Text == "yes")
            { Flag = true;
            }

                if (Flag==true)
            {
                WriteTOFile();
                MessageBox.Show("Account Created");
                this.Hide();
                PayMatic open=new PayMatic();
                open.FormClosed+=(s,args)=>this.Close();
                open.Show();

            }
        }

            private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true &&radioButton1.Checked==true)
            {
                radioButton2.Checked = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp open=new SignUp();
            this.Hide();
            open.FormClosed+=(s,args)=>this.Close();
            open.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "YES")
            {
                this.Hide();
                PayMatic open = new PayMatic();
                open.FormClosed += (s, args) => this.Close();
                open.Show();
            }

        }
    }
}
