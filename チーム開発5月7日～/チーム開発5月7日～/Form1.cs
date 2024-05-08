using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace チーム開発5月7日_
{
    public partial class Form1 : Form
    {
        string[] foods;
        public Form1()
        {
            InitializeComponent();
        }

        /*起動時の処理*/
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            testlabel.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string x in foods)
            {
                testlabel.Text =
                x;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text =now.ToLongTimeString();
        }
    }
}
