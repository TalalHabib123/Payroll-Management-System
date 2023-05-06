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
    public partial class SalarySlip : Form
    {
        public string EmployeeID;
        public string EmployeeName;
        public SalarySlip()
        {
            InitializeComponent();
        }

        private void SalarySlip_Load(object sender, EventArgs e)
        {
            NameEmp.Text = EmployeeName;
            IDEmp.Text = EmployeeID;
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
            DEPEmp.Text = temp5;
            POSEmp.Text = temp6;
            StreamReader sw = new StreamReader("Salary.txt");
            temp1= sw.ReadLine();
            temp2= sw.ReadLine();
            temp3= sw.ReadLine();
            temp4= sw.ReadLine();
            while(temp1 != null)
            {
                if(temp1==EmployeeID)
                {
                    break;
                }
                temp1 = sw.ReadLine();
                temp2 = sw.ReadLine();
                temp3 = sw.ReadLine();
                temp4 = sw.ReadLine();
            }
            sw.Close();
            EMPSAL.Text = "$"+temp2;
            EMPded.Text = "$" + temp3;
            EmpEarn.Text = "$" + temp2;
            EMPtax.Text = "$" + temp3;
            Salary.Text = "$" + temp4;
        }
    }
}
