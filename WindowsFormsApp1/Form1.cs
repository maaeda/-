using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*画像の表示*/
            this.Text = ProductName;
            //pictureBox1.Dock = DockStyle.Fill;    // フォームいっぱいに貼り付ける
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // 縦横比を変えずに引き延ばす
            pictureBox1.Image = Properties.Resources.test; //画像表示
            /************/

            timer1.Start();
            foodlabel.Text = " ";

        }

        private void timer1_tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            timelabel.Text = now.ToLongTimeString();
        }


    }
}