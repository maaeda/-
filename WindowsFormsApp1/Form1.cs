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
using System.Diagnostics;
using Windows.Perception.People;


namespace WindowsFormsApp1
{
    //test
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        string weatherImageUrl = "";
        /*numに代入された番号のレシピを介します。デフォルトは0です。*/
        int foodNum = 0;
        // 天気APIのURL(ここで月を取得し対応した楽天レシピAPIを返す)
        string apiUrl = "https://weather.tsukumijima.net/api/forecast/city/070010";
        static int season = 0;
        string month;
        string toDay = 0.ToString();
        int annivCnt = 1;



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

            detailWeatherLabel.BackColor = Color.Transparent;
            locationPrefecturLabel.BackColor = Color.Transparent;



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
                month = date.Substring(startindex, monthlength);
                toDay = date.Substring(8, 2);
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
                locationPrefecturLabel.Text = (string)weatherData["location"]["prefecture"]+" "+ (string)weatherData["location"]["district"];
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


            try
            {
                string currentData = DateTime.Now.ToString("MMdd");
                HttpResponseMessage response = await _httpClient.GetAsync($"https://whatistoday.cyou/v2/anniv/{currentData}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // JSONデータを解析します。
                JObject annivData = JObject.Parse(responseBody);

                /*今日は何の日*/
                whatTodayLabel.Text = "今日は..."+(string)annivData["_items"][0][$"anniv{annivCnt}"];

            }
            catch (HttpRequestException ex)
            {

            }

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
                /*通知*/
                new ToastContentBuilder()
                    .AddText("作れるもんなら作ってみな!")
                    .AddText((string)foodData["result"][foodNum]["recipeTitle"])
                    //.AddInlineImage(new Uri((string)foodData["result"][foodNum]["foodImageUrl"]))
                    //AddHeroImage(new Uri("https://learn.microsoft.com/ja-jp/windows/apps/design/shell/tiles-and-notifications/images/toast-content-hero-image.png"))
                    .Show();

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

                    /*notiImageに画像を入れる*/
                    var notiImage = loadImageFromURL((string)foodData["result"][foodNum]["foodImageUrl"]);
                    //pictureBox1.Image = notiImage;

                    /*通知*/
                    new ToastContentBuilder()
                        .AddText("作れるもんなら作ってみな!")
                        .AddText((string)foodData["result"][foodNum]["recipeTitle"])
                        //.AddInlineImage(new Uri("fille:///Resources/test.jpg"))
                        .Show();

                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"エラーが発生しました: {ex.Message}");
                }
        }

        /*リンク画像をimage型に変換　*/
        public static System.Drawing.Image loadImageFromURL( string url ) {
            int buffSize = 65536; // 一度に読み込むサイズ
            MemoryStream imgStream = new MemoryStream();

            //------------------------
            // パラメータチェック
            //------------------------
            if ( url == null || url.Trim().Length <= 0 ) {
                return null;
            }

            //----------------------------
            // Webサーバに要求を投げる
            //----------------------------
            WebRequest req = WebRequest.Create( url );
            BinaryReader reader = new BinaryReader( req.GetResponse().GetResponseStream() );

            //--------------------------------------------------------
            // Webサーバからの応答データを取得し、imgStreamに保存する
            //--------------------------------------------------------
            while ( true ) {
                byte[] buff = new byte[ buffSize ];

                // 応答データの取得
                int readBytes = reader.Read( buff, 0, buffSize );
                if ( readBytes <= 0 ) {
                    // 最後まで取得した->ループを抜ける
                    break;
                }

                // バッファに追加
                imgStream.Write( buff, 0, readBytes );
            }

            return new Bitmap( imgStream );
        }

        public class Category
        {
            public string CategoryName { get; set; }
            public string CategoryId { get; set; }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string foodApiUrl = $"https://app.rakuten.co.jp/services/api/Recipe/CategoryRanking/20170426?format=json&categoryId={season}&pickup=0&applicationId=1062554798332159397";
            try
            {

                HttpResponseMessage response = await _httpClient.GetAsync(foodApiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject foodData = JObject.Parse(responseBody);

                // リンクを既定のブラウザで開く
                Process.Start((string)foodData["result"][foodNum]["recipeUrl"]);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"エラーが発生しました: {ex.Message}");
            }
        }

        private void weatherIconWeb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            annivCnt += 1;
            string whatToday = "";
            try
            {
                string currentData = DateTime.Now.ToString("MMdd");
                HttpResponseMessage response = await _httpClient.GetAsync($"https://whatistoday.cyou/v2/anniv/{currentData}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // JSONデータを解析します。
                JObject annivData = JObject.Parse(responseBody);
                whatToday = (string)annivData["_items"][0][$"anniv{annivCnt}"];
                if(whatToday == "" )
                {
                    annivCnt = 0;
                }

                /*今日は何の日*/
                whatTodayLabel.Text = "今日は..." + (string)annivData["_items"][0][$"anniv{annivCnt}"];


            }
            catch (HttpRequestException ex)
            {

            }
            if ( annivCnt >= 5 ) {
            annivCnt = 0;
            }
        }
    }
}