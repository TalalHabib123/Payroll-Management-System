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
    public partial class Attendance : Form
    {
        public string EmployeeID;
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            StreamReader sw = new StreamReader("Attendance.txt");
            string line = sw.ReadLine();
            while(line != null)
            {
                if(line==EmployeeID)
                {
                    break;
                }
                line = sw.ReadLine();
            }
            string Date = sw.ReadLine();
            string Attendance = sw.ReadLine();
            int i = 1;
            string[] row = { i.ToString(),Date, Attendance };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
            while (Date != "Next")
            {
                Date = sw.ReadLine();
                Attendance = sw.ReadLine();
                i++;
                if (Date == "Next")
                {
                    break;
                }
                string[] row1 = { i.ToString(),Date, Attendance };
                var listViewItem1 = new ListViewItem(row1);
                listView1.Items.Add(listViewItem1);
                
            }
        }
    }
}
