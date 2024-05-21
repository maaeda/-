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
using Microsoft.Toolkit.Uwp.Notifications;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        string weatherImageUrl = "";
        /*numに代入された番号のレシピを介します。デフォルトは0です。*/
        int foodNum = 0;
        // 天気APIのURL(ここで月を取得し対応した楽天レシピAPIを返す)
        string apiUrl = "https://weather.tsukumijima.net/api/forecast/city/070010";
        static int season = 0;




        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            
            

            


            

            /*背景画像の表示*/
            /*
            this.Text = ProductName;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // 縦横比を変えずに引き延ばす
            pictureBox1.Image = Properties.Resources.test; //画像表示
            /************/

            /*天気取得*/
            
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

                // APIから月を取得し季節ごとの数値を変数seasonに代入
                string date = (string)weatherData["forecasts"][day]["date"];
                int startindex= 5;
                int monthlength = 2;
                string month = date.Substring(startindex, monthlength);
                switch (month)
                {
                    // 春
                    case "03":
                    case "04":
                    case "05":
                        monthrecipelabel.Text = "春のおすすめレシピ!";
                        season = 52;
                        break;
                    // 夏
                    case "06":
                    case "07":
                    case "08":
                        monthrecipelabel.Text = "夏のおすすめレシピ!";
                        season = 53;
                        break;
                    // 秋
                    case "09":
                    case "10":
                    case "11":
                        monthrecipelabel.Text = "秋のおすすめレシピ!";
                        season = 54;
                        break;
                    // 冬
                    case "12":
                    case "01":
                    case "02":
                        monthrecipelabel.Text = "冬のおすすめレシピ!";
                        season = 55;
                        break;

                }


                string weatherDetail = (string)weatherData["forecasts"][day]["telop"];

                weatherImageUrl             = (string)weatherData["forecasts"][day]["image"]["url"];
                locationPrefecturLabel.Text = (string)weatherData["location"]["prefecture"];
                locationDistrictLabel.Text  = (string)weatherData["location"]["district"];
                detailWeatherLabel.Text     = (string)weatherData["forecasts"][day]["detail"]["weather"];
                bodyLabal.Text              = (string)weatherData["description"]["bodyText"];
                datelabel.Text              = (string)weatherData["forecasts"][day]["date"];
                /***********************/



            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"エラーが発生しました: {ex.Message}");
            }
            /**********************/

            /*天気ロゴを表示*/
            weatherIconWeb.Navigate(weatherImageUrl);
            /*
            // PictureBoxをフォームに追加し、SizeModeをStretchImageに設定します。
            weatherPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            // SVGファイルを読み込みます。
            var svgDocument = SvgDocument.Open(weatherImageUrl);
            // SVGをBitmapに変換します。
            Bitmap bmp = svgDocument.Draw();
            // PictureBoxに表示します。
            weatherPictureBox.Image = bmp;
            */
            /*************/

            // 上で取得した月をもとにリンクを取得 ------------------------------------------------------------------------------ ↓↓↓ここにseason変数が代入され、季節別にURLに変わる
            string foodApiUrl = $"https://app.rakuten.co.jp/services/api/Recipe/CategoryRanking/20170426?format=json&categoryId={season}&pickup=0&applicationId=1062554798332159397";


            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(foodApiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // JSONデータを解析します。
                JObject foodData = JObject.Parse(responseBody);

                // 「food」の項目を取得します。

                this.Text = ProductName;
                foodPicutrebox.SizeMode = PictureBoxSizeMode.Zoom;
                foodPicutrebox.ImageLocation = (string)foodData["result"][foodNum]["foodImageUrl"];
                foodLabel.Text = (string)foodData["result"][foodNum]["recipeTitle"];
                /***********************/
            }
            catch (HttpRequestException ex)
            {
                switch (ex.Message)
                {
                    case "400":
                        MessageBox.Show($"パラメーターエラーが発生しました。エラーコード。: {ex.Message}");
                        break;

                    case "401":
                        MessageBox.Show($"不正なトークンによるエラーが発生しました。エラーコード: {ex.Message}");
                        break;

                    case "403":
                        MessageBox.Show($"許可スコープが十分ではありません。エラーコード: {ex.Message}");
                        break;

                    case "503":
                        MessageBox.Show($"APIメンテンス。エラーコード: {ex.Message}");
                        break;

                    case "500":
                        MessageBox.Show($"APIトラブル。エラーコード: {ex.Message}");
                        break;

                    case "429":
                        MessageBox.Show($"APIリクエスト制限。エラーコード: {ex.Message}");
                        break;

                    default:
                        MessageBox.Show($"予期せぬエラーが発生しました。エラーコード: {ex.Message}");
                        break;
                }
            }


            timer1.Start();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            timelabel.Text = now.ToLongTimeString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
                string foodApiUrl = $"https://app.rakuten.co.jp/services/api/Recipe/CategoryRanking/20170426?format=json&categoryId={season}&pickup=0&applicationId=1062554798332159397";
                try
                {
                
                HttpResponseMessage response = await _httpClient.GetAsync(foodApiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // JSONデータを解析します。
                    JObject foodData = JObject.Parse(responseBody);

                foodNum = ++foodNum;
                if (foodNum > 3)
                {
                    foodNum = 0;
                }

                // 「food」の項目を取得します。

                this.Text = ProductName;
                    foodPicutrebox.SizeMode = PictureBoxSizeMode.Zoom;
                    foodPicutrebox.ImageLocation = (string)foodData["result"][foodNum]["foodImageUrl"];
                    foodLabel.Text               = (string)foodData["result"][foodNum]["recipeTitle"];
                    /***********************/
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"エラーが発生しました: {ex.Message}");
                }

            /*通知*/
            new ToastContentBuilder()
                .AddText("My Toast")
                .AddText("Hello Toast!")
                .Show();

        }

        public class Category
        {
            public string CategoryName { get; set; }
            public string CategoryId { get; set; }
        }
    }
}