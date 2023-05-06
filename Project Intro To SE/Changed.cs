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
    public partial class Changed : Form
    {
        public Changed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login open = new Login();
            open.FormClosed += (s, args) => this.Close();
            open.Show();
        }

        private void Changed_Load(object sender, EventArgs e)
        {

        }
    }
}
