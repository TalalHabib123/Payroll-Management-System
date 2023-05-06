using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Intro_To_SE
{
    public partial class Edit : Form
    {
        public string EmployeeID;
        public string EmployeeName;
        public Edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditLeaves open=new EditLeaves();  
            open.EmployeeID=EmployeeID;
            open.Show();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EditData open = new EditData();
            open.EmployeeID = EmployeeID;
            open.Show();
            this.Show();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            label3.Text = EmployeeName;
            label5.Text = EmployeeID;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditSalary open=new EditSalary();
            open.EmployeeID=EmployeeID;
            open.Show();
            this.Show();
        }
    }
}
