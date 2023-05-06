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
    public partial class PayMatic : Form
    {
        public PayMatic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Open_Page = new Login();
            Open_Page.Closed += (s,args) =>this.Close();
            Open_Page.Show();
        }

        private void Open_Page_Closed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp Open_Page = new SignUp();
            Open_Page.FormClosed+=(s,args) =>this.Close();
            Open_Page.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
        }
    }
}
