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
    public partial class AddNews : Form
    {
        public AddNews()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            if(comboBox1.SelectedItem== null || comboBox2.SelectedItem==null || comboBox3.SelectedItem==null)
            {
                check = false;
                label4.Show();
            }
            if(textBox1.Text=="" || textBox2.Text=="" ||textBox1.Text==null || textBox2.Text==null)
            {
                check=false;
                label4.Show();
            }
            if(check)
            {
                string date = comboBox1.Text + "-" + comboBox2.Text + "-" + comboBox3.Text;
                string subject = textBox2.Text;
                string news_add = textBox1.Text;
                FileStream fs = new FileStream("News.txt", FileMode.Append, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(date);
                    sw.WriteLine(subject);
                    sw.WriteLine(news_add);
                }
                MessageBox.Show("News Added");
                fs.Close();
                this.Close();
            }
            
        }

        private void AddNews_Load(object sender, EventArgs e)
        {
            label4.Hide();
        }
    }
}
