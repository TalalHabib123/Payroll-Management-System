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
    public partial class DisplayNews : Form
    {
        public string Date;
        public string Title;
        public DisplayNews()
        {
            InitializeComponent();
        }

        private void DisplayNews_Load(object sender, EventArgs e)
        {
            label5.Text = Title;
            label6.Text = Date;
            StreamReader sr = new StreamReader("News.txt");
            string line1=sr.ReadLine();
            string line2=sr.ReadLine();
            string line3=sr.ReadLine();
            string News="";
            while (line1 != null)
            {
                if(line1==Date && line2==Title)
                {
                    News = line3;
                    break;
                }
                line1 = sr.ReadLine();
                line2 = sr.ReadLine();
                line3 = sr.ReadLine();
            }
            label7.Text = line3;
            sr.Close();
        }
    }
}
