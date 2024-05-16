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
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using Svg;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        private readonly HttpClient _httpClient = new HttpClient();
        static readonly string recipeCategoryUrl = $"https://app.rakuten.co.jp/services/api/Recipe/CategoryList/20170426?applicationId=1062554798332159397";

        string weatherImageUrl = "";
        string[] breakfastfoods = { "aaa", "bbb", "ccc" };// 朝ご飯を入れる大域変数
        string[] lunchfoods = { "aaa", "bbb", "ccc" };// 朝ご飯を入れる大域変数
        string[] dinnerfoods = { "aaa", "bbb", "ccc" };// 朝ご飯を入れる大域変数

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // 料理カテゴリの中からランダムでfoodlabelに表示させる処理
            try
            {
                var response = await _httpClient.GetStringAsync(recipeCategoryUrl);
                var data = JObject.Parse(response);
                var categories = data["result"]["small"].ToObject<Category[]>();

                var random = new Random();
                var randomCategory = categories[random.Next(categories.Length)];

                foodLabel.Text = "カテゴリID" + randomCategory.CategoryId + "　" + randomCategory.CategoryName;
            }
            catch (HttpRequestException ex)
            {
                foodLabel.Text = "Message :{0} "+ ex.Message;
            }
            /******************/

            /*画像の表示　　今のところ使いません*/
            //this.Text = ProductName;
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // 縦横比を変えずに引き延ばす
            //pictureBox1.Image = Properties.Resources.test; //画像表示
            /************/

            /*API*/
            string foodApiUrl = "https://app.rakuten.co.jp/services/api/Recipe/CategoryList/20170426?applicationId=1062554798332159397";
            /*****/

            /*天気取得*/
            string apiUrl = "https://weather.tsukumijima.net/api/forecast/city/070010";
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // JSONデータを解析します。
                JObject weatherData = JObject.Parse(responseBody);

                // 「天気」の項目を取得します。

                /*取得する日にちの設定*/
                int day = 0;
                /*
                 * 0 = 今日
                 * 1 = 明日
                 * 2 = 明後日
                 * 変更されるのは画像と簡単な予報のみ -> weatherImageUrl & detailWeatherLabel.Text
                 */

                string weatherDetail = (string)weatherData["forecasts"][day]["telop"];

                weatherImageUrl             = (string)weatherData["forecasts"][day]["image"]["url"];
                locationPrefecturLabel.Text = (string)weatherData["location"]["prefecture"];
                locationDistrictLabel.Text  = (string)weatherData["location"]["district"];
                detailWeatherLabel.Text     = (string)weatherData["forecasts"][day]["detail"]["weather"];
                bodyLabal.Text              = (string)weatherData["description"]["bodyText"];
                

                // 天気に応じた画像を表示します。
                // 例えば、「晴れ」の場合は晴れのラベルを、
                // 「雨」の場合は雨のラベルを表示します。
                // あとは自由に天気を追加することも可( 雨のち晴れ など)
                /*
                switch (weather)
                {
                    case "晴れ":
                        titleLabal.Text = "晴れ";
                        break;
                    case "曇り":
                        titleLabal.Text = "曇り";
                        break;
                    case "雨":
                        titleLabal.Text = "雨";
                        break;
                    case "晴のち曇":
                        titleLabal.Text = "晴れのち曇り";
                        break;
                    // 他の天気の条件も同様に追加します。
                    default:
                        titleLabal.Text = "不明";
                        break;
                }
                */
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"エラーが発生しました: {ex.Message}");
            }
            /**********************/

            /*天気ロゴを表示*/
            webBrowser1.Navigate(weatherImageUrl);
            /*************/

            timer1.Start();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            timelabel.Text = now.ToLongTimeString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 料理カテゴリの中からランダムでfoodlabelに表示させる処理
            try
            {
                var response = await _httpClient.GetStringAsync(recipeCategoryUrl);
                var data = JObject.Parse(response);
                var categories = data["result"]["small"].ToObject<Category[]>();

                var random = new Random();
                var randomCategory = categories[random.Next(categories.Length)];

                foodLabel.Text = "カテゴリID" + randomCategory.CategoryId + "　" + randomCategory.CategoryName;
            }
            catch (HttpRequestException ex)
            {
                foodLabel.Text = "Message :{0} "+ ex.Message;
            }
            /******************/
        }

        public class Category
        {
            public string CategoryName { get; set; }
            public string CategoryId { get; set; }
        }

        private void locationPrefecturLabel_Click(object sender, EventArgs e)
        {

        }
    }
}