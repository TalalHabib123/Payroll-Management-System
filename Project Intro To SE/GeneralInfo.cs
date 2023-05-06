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
    public partial class GeneralInfo : Form
    {
        public string EmployeeID;
        public GeneralInfo()
        {
            InitializeComponent();
        }

        private void GeneralInfo_Load(object sender, EventArgs e)
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
            while(temp1 != null)
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
                temp8 = sr.ReadLine();
                temp9 = sr.ReadLine();
            }
            sr.Close(); 
            label9.Text= temp2;
            label10.Text= temp3;
            label11.Text= temp4;
            label12.Text= temp8;
            label14.Text= temp5;
            label17.Text= temp6;
            label13.Text= temp7;
            label15.Text = temp9;

        }
    }
}
