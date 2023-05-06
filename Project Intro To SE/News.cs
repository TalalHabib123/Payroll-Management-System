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
    public partial class News : UserControl
    {
        public News()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNews open=new AddNews();
            open.Show();
            this.Refresh();
        }

        private void News_Load(object sender, EventArgs e)
        {
            label2.Hide();
            listView1.Columns.Add("Date Added", 100);
            listView1.Columns.Add("Subject News",500);
            StreamReader sw = new StreamReader("News.txt");
            string Date=sw.ReadLine();
            string Subject=sw.ReadLine();   
            string News_Topic=sw.ReadLine();
            string[] row = { Date, Subject };
            var listViewItem=new ListViewItem(row);
            listView1.Items.Add(listViewItem); 
            while(Date!=null)
            {
                Date = sw.ReadLine();
                Subject = sw.ReadLine();
                News_Topic = sw.ReadLine();
                string[] row1 = { Date, Subject };
                var listViewItem1 = new ListViewItem(row1);
                listView1.Items.Add(listViewItem1);
            }
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string Date = listView1.SelectedItems[0].SubItems[0].Text;
                string Title = listView1.SelectedItems[0].SubItems[1].Text;
                DisplayNews open=new DisplayNews(); 
                open.Date = Date;   
                open.Title = Title; 
                open.Show();
                this.Show();

            }
            else if (listView1.SelectedItems.Count == 0)
            {
                label2.Show();
            }
        }

        private void none(object sender, EventArgs e)
        {

        }
    }
}
