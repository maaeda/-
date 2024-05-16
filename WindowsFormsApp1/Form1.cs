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
        string weatherImageUrl = "";

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string foodApiUrl = "https://app.rakuten.co.jp/services/api/Recipe/CategoryRanking/20170426?format=json&categoryId=10&pickup=0&applicationId=1062554798332159397";
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(foodApiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // JSONデータを解析します。
                JObject foodData = JObject.Parse(responseBody);

                // 「food」の項目を取得します。
                /*取得の設定*/
                int num = 0;
                /*
                 * 0
                 * 1
                 * 2
                 */
                this.Text = ProductName;
                foodPicutrebox.SizeMode = PictureBoxSizeMode.AutoSize;
                foodPicutrebox.ImageLocation = (string)foodData["result"][num]["foodImageUrl"];
                foodLabel.Text               = (string)foodData["result"][num]["recipeTitle"];
                /***********************/
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"エラーが発生しました: {ex.Message}");
            }

            /*背景画像の表示*/
            /*
            this.Text = ProductName;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // 縦横比を変えずに引き延ばす
            pictureBox1.Image = Properties.Resources.test; //画像表示
            /************/

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
                /***********************/
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"エラーが発生しました: {ex.Message}");
            }
            /**********************/

            /*天気ロゴを表示*/
            weatherIconWeb.Navigate(weatherImageUrl);
            /*************/

            timer1.Start();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            timelabel.Text = now.ToLongTimeString();
        }

        int i = 0;
        private async void button1_Click(object sender, EventArgs e)
        {
            i = ++i;
                string foodApiUrl = "https://app.rakuten.co.jp/services/api/Recipe/CategoryRanking/20170426?format=json&categoryId=10&pickup=0&applicationId=1062554798332159397";
                try
                {
                    HttpResponseMessage response = await _httpClient.GetAsync(foodApiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // JSONデータを解析します。
                    JObject foodData = JObject.Parse(responseBody);

                    // 「food」の項目を取得します。
                    /*取得の設定*/
                    int num = 1;
                    /*
                     * 0
                     * 1
                     * 2
                     */
                    this.Text = ProductName;
                    foodPicutrebox.SizeMode = PictureBoxSizeMode.AutoSize;
                    foodPicutrebox.ImageLocation = (string)foodData["result"][i]["foodImageUrl"];
                    foodLabel.Text               = (string)foodData["result"][i]["recipeTitle"];
                    /***********************/
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"エラーが発生しました: {ex.Message}");
                }
            
        }

        public class Category
        {
            public string CategoryName { get; set; }
            public string CategoryId { get; set; }
        }
    }
}