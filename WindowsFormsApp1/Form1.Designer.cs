namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timelabel = new System.Windows.Forms.Label();
            this.locationPrefecturLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.foodLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bodyLabal = new System.Windows.Forms.Label();
            this.detailWeatherLabel = new System.Windows.Forms.Label();
            this.weatherIconWeb = new System.Windows.Forms.WebBrowser();
            this.monthrecipelabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Food = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.foodPicutrebox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.weatherinfotext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.whatTodayLabel = new System.Windows.Forms.Label();
            this.whatTodayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicutrebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.BackColor = System.Drawing.Color.Khaki;
            this.timelabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timelabel.Font = new System.Drawing.Font("Stencil", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.Location = new System.Drawing.Point(341, 30);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(127, 35);
            this.timelabel.TabIndex = 1;
            this.timelabel.Text = "label1";
            // 
            // locationPrefecturLabel
            // 
            this.locationPrefecturLabel.AutoSize = true;
            this.locationPrefecturLabel.BackColor = System.Drawing.Color.Transparent;
            this.locationPrefecturLabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.locationPrefecturLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.locationPrefecturLabel.Location = new System.Drawing.Point(142, 104);
            this.locationPrefecturLabel.Name = "locationPrefecturLabel";
            this.locationPrefecturLabel.Size = new System.Drawing.Size(227, 28);
            this.locationPrefecturLabel.TabIndex = 1;
            this.locationPrefecturLabel.Text = "locationPrefectur";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.BackColor = System.Drawing.Color.White;
            this.foodLabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.foodLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.foodLabel.Location = new System.Drawing.Point(421, 174);
            this.foodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(92, 20);
            this.foodLabel.TabIndex = 2;
            this.foodLabel.Text = "foodLabel";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(419, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "別のレシピを見る";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bodyLabal
            // 
            this.bodyLabal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bodyLabal.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bodyLabal.Location = new System.Drawing.Point(91, 194);
            this.bodyLabal.Name = "bodyLabal";
            this.bodyLabal.Size = new System.Drawing.Size(312, 254);
            this.bodyLabal.TabIndex = 1;
            this.bodyLabal.Text = "bodyLabal";
            // 
            // detailWeatherLabel
            // 
            this.detailWeatherLabel.AutoSize = true;
            this.detailWeatherLabel.BackColor = System.Drawing.Color.Transparent;
            this.detailWeatherLabel.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.detailWeatherLabel.Location = new System.Drawing.Point(142, 150);
            this.detailWeatherLabel.Name = "detailWeatherLabel";
            this.detailWeatherLabel.Size = new System.Drawing.Size(253, 28);
            this.detailWeatherLabel.TabIndex = 1;
            this.detailWeatherLabel.Text = "detailWeatherLabel";
            // 
            // weatherIconWeb
            // 
            this.weatherIconWeb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.weatherIconWeb.AllowWebBrowserDrop = false;
            this.weatherIconWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.weatherIconWeb.CausesValidation = false;
            this.weatherIconWeb.Location = new System.Drawing.Point(88, 142);
            this.weatherIconWeb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.weatherIconWeb.Name = "weatherIconWeb";
            this.weatherIconWeb.ScrollBarsEnabled = false;
            this.weatherIconWeb.Size = new System.Drawing.Size(49, 44);
            this.weatherIconWeb.TabIndex = 4;
            this.weatherIconWeb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.weatherIconWeb_DocumentCompleted);
            // 
            // monthrecipelabel
            // 
            this.monthrecipelabel.AutoSize = true;
            this.monthrecipelabel.BackColor = System.Drawing.Color.NavajoWhite;
            this.monthrecipelabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.monthrecipelabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.monthrecipelabel.Location = new System.Drawing.Point(421, 150);
            this.monthrecipelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthrecipelabel.Name = "monthrecipelabel";
            this.monthrecipelabel.Size = new System.Drawing.Size(61, 20);
            this.monthrecipelabel.TabIndex = 5;
            this.monthrecipelabel.Text = "label1";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.datelabel.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.datelabel.Location = new System.Drawing.Point(655, 14);
            this.datelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(83, 22);
            this.datelabel.TabIndex = 6;
            this.datelabel.Text = "label1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(548, 106);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "レシピサイトを表示\r\n(ブラウザが開きます)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Food
            // 
            this.Food.AutoSize = true;
            this.Food.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Food.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food.ForeColor = System.Drawing.Color.DarkOrange;
            this.Food.Location = new System.Drawing.Point(370, 6);
            this.Food.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(70, 26);
            this.Food.TabIndex = 8;
            this.Food.Text = "Food";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.currentlocationpin;
            this.pictureBox2.Location = new System.Drawing.Point(100, 94);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // foodPicutrebox
            // 
            this.foodPicutrebox.BackColor = System.Drawing.Color.Moccasin;
            this.foodPicutrebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.foodPicutrebox.Location = new System.Drawing.Point(419, 194);
            this.foodPicutrebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodPicutrebox.Name = "foodPicutrebox";
            this.foodPicutrebox.Size = new System.Drawing.Size(195, 254);
            this.foodPicutrebox.TabIndex = 0;
            this.foodPicutrebox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.r;
            this.pictureBox1.Location = new System.Drawing.Point(-63, -10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 528);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // weatherinfotext
            // 
            this.weatherinfotext.AutoSize = true;
            this.weatherinfotext.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.weatherinfotext.Location = new System.Drawing.Point(140, 66);
            this.weatherinfotext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weatherinfotext.Name = "weatherinfotext";
            this.weatherinfotext.Size = new System.Drawing.Size(189, 33);
            this.weatherinfotext.TabIndex = 10;
            this.weatherinfotext.Text = "-本日の天気情報-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(480, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "-料理コーナー";
            // 
            // whatTodayLabel
            // 
            this.whatTodayLabel.AutoSize = true;
            this.whatTodayLabel.BackColor = System.Drawing.Color.White;
            this.whatTodayLabel.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.whatTodayLabel.Location = new System.Drawing.Point(88, 2);
            this.whatTodayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.whatTodayLabel.Name = "whatTodayLabel";
            this.whatTodayLabel.Size = new System.Drawing.Size(148, 24);
            this.whatTodayLabel.TabIndex = 11;
            this.whatTodayLabel.Text = "whatTodayLabel";
            // 
            // whatTodayButton
            // 
            this.whatTodayButton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.whatTodayButton.Location = new System.Drawing.Point(91, 30);
            this.whatTodayButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.whatTodayButton.Name = "whatTodayButton";
            this.whatTodayButton.Size = new System.Drawing.Size(81, 24);
            this.whatTodayButton.TabIndex = 12;
            this.whatTodayButton.Text = "記念日更新";
            this.whatTodayButton.UseVisualStyleBackColor = true;
            this.whatTodayButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(809, 486);
            this.Controls.Add(this.whatTodayButton);
            this.Controls.Add(this.whatTodayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weatherinfotext);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.monthrecipelabel);
            this.Controls.Add(this.weatherIconWeb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.detailWeatherLabel);
            this.Controls.Add(this.bodyLabal);
            this.Controls.Add(this.locationPrefecturLabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.foodPicutrebox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BEST MEAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicutrebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label whatTodayLabel;

        private System.Windows.Forms.PictureBox foodPicutrebox;

        private System.Windows.Forms.Label bodyLabal;
        private System.Windows.Forms.Label detailWeatherLabel;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label locationPrefecturLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label monthrecipelabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Food;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.WebBrowser weatherIconWeb;
        private System.Windows.Forms.Label weatherinfotext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button whatTodayButton;
    }
}