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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load_1(object sender, EventArgs e)
        {
            label5.Hide();
            label6.Hide();
            label7.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Hide();
            label6.Hide();
            label7.Hide();
            bool Flag = true;
            bool ID_Check = false; 
            bool Mobile_Check = false;
            string ID=textBox1.Text;
            string mobile=textBox2.Text;   
            string password=textBox3.Text;
            string temp,temp1,temp2,temp3,temp4,temp5,temp6,temp7;
            StreamReader sr=new StreamReader("SignUpData.txt");
            temp=sr.ReadLine();   //id
            temp1 = sr.ReadLine();  //name
            temp2 = sr.ReadLine();  //emiail
            temp3 = sr.ReadLine();  //MOBILE
            temp4=sr.ReadLine();     //PASSWROD
            temp5 = sr.ReadLine();    //DOB
            temp6 = sr.ReadLine();      //GENDER
            temp7 = sr.ReadLine();      //ADDRESS
            while(temp!=null)
            {
                if(temp==ID)
                {
                    ID_Check = true;
                    if(temp3==mobile)
                    {
                        Mobile_Check = true;
                        break;
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
            string OLD_passwrod = temp4;
            sr.Close();
            if(!(textBox3.Text.Length>=8 &&textBox3.Text.Length<=15))
            {
                label7.Show();
                Flag=false;
            }
            if(Mobile_Check==true && ID_Check==true && Flag==true)
            {
                string File_Read = File.ReadAllText("SignUpData.txt");
                File_Read =File_Read.Replace(OLD_passwrod,password);
                File.WriteAllText("SignUpData.txt",File_Read);
                this.Hide();
                Changed open=new Changed();
                open.FormClosed+=(s,args)=>this.Close();
                open.Show();
            }
            if (!ID_Check)
            {
                label5.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            if(!Mobile_Check)
            {
                label6.Show();
            }
        }

        private void Open_Closed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login open = new Login();
            this.Hide();
            open.FormClosed += (s, args) => this.Close();
            open.Show();
        }

        private void label1_Click(object sender, EventArgs e)       //USELESSS
        {

        }
    }
}
