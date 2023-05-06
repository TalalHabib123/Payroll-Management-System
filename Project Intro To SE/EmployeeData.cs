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
    public partial class EmployeeData : UserControl
    {
        public EmployeeData()
        {
            InitializeComponent();
        }

        private void EmployeeData_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("EmployeeData.txt");
            string temp1, temp2, temp3, temp4, temp5, temp6, temp7, temp8, temp9;
            temp1=sr.ReadLine();
            temp2=sr.ReadLine();
            temp3=sr.ReadLine();
            temp4=sr.ReadLine();
            temp5=sr.ReadLine();
            temp6=sr.ReadLine();
            temp7=sr.ReadLine();
            temp8=sr.ReadLine();
            temp9=sr.ReadLine();
            while(temp1!=null)
            {
                string[] row = {temp1,temp2,temp5,temp6};
                var line=new ListViewItem(row);
                listView1.Items.Add(line);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                Employee emp = new Employee();
                emp.LoginAdmin = true;
                emp.EmployeeID = listView1.SelectedItems[0].SubItems[0].Text; 
                emp.name=listView1.SelectedItems[0].SubItems[1].Text;
                emp.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                Edit emp = new Edit();
                emp.EmployeeID = listView1.SelectedItems[0].SubItems[0].Text;
                emp.EmployeeName = listView1.SelectedItems[0].SubItems[1].Text;
                emp.Show();
                this.Refresh();
            }
        }
    }
}
