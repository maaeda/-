using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        string[] breakfastfoods = { "aaa", "bbb", "ccc" };// 朝ご飯を入れる大域変数
        string[] lunchfoods = { "aaa", "bbb", "ccc" };// 朝ご飯を入れる大域変数
        string[] dinnerfoods = { "aaa", "bbb", "ccc" };// 朝ご飯を入れる大域変数


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

            /*API*/
            string apiUrl = "https://app.rakuten.co.jp/services/api/Recipe/CategoryList/20170426?applicationId=1062554798332159397";

            /*****/

            timer1.Start();
            foodlabel.Text = " ";

        }

        private void timer1_tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            timelabel.Text = now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foodlabel.Text = "HELP!!!!!!!!!!!!!!!!";
                
        }
    }
}