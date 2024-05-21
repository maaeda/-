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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timelabel = new System.Windows.Forms.Label();
            this.locationPrefecturLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.foodLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bodyLabal = new System.Windows.Forms.Label();
            this.detailWeatherLabel = new System.Windows.Forms.Label();
            this.weatherIconWeb = new System.Windows.Forms.WebBrowser();
            this.locationDistrictLabel = new System.Windows.Forms.Label();
            this.foodPicutrebox = new System.Windows.Forms.PictureBox();
            this.monthrecipelabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.weatherPictureBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicutrebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1050, 668);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timelabel.Font = new System.Drawing.Font("Meiryo UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timelabel.Location = new System.Drawing.Point(504, 14);
            this.timelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(207, 77);
            this.timelabel.TabIndex = 1;
            this.timelabel.Text = "label1";
            // 
            // locationPrefecturLabel
            // 
            this.locationPrefecturLabel.AutoSize = true;
            this.locationPrefecturLabel.Font = new System.Drawing.Font("Meiryo UI", 14F, System.Drawing.FontStyle.Bold);
            this.locationPrefecturLabel.Location = new System.Drawing.Point(74, 102);
            this.locationPrefecturLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationPrefecturLabel.Name = "locationPrefecturLabel";
            this.locationPrefecturLabel.Size = new System.Drawing.Size(229, 30);
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
            this.foodLabel.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.foodLabel.Location = new System.Drawing.Point(513, 178);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(115, 24);
            this.foodLabel.TabIndex = 2;
            this.foodLabel.Text = "foodLabel";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(517, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "別のレシピを見る";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bodyLabal
            // 
            this.bodyLabal.Font = new System.Drawing.Font("Meiryo UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bodyLabal.Location = new System.Drawing.Point(20, 231);
            this.bodyLabal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bodyLabal.Name = "bodyLabal";
            this.bodyLabal.Size = new System.Drawing.Size(455, 310);
            this.bodyLabal.TabIndex = 1;
            this.bodyLabal.Text = "bodyLabal";
            // 
            // detailWeatherLabel
            // 
            this.detailWeatherLabel.AutoSize = true;
            this.detailWeatherLabel.Font = new System.Drawing.Font("Meiryo UI", 14F, System.Drawing.FontStyle.Bold);
            this.detailWeatherLabel.Location = new System.Drawing.Point(74, 178);
            this.detailWeatherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailWeatherLabel.Name = "detailWeatherLabel";
            this.detailWeatherLabel.Size = new System.Drawing.Size(256, 30);
            this.detailWeatherLabel.TabIndex = 1;
            this.detailWeatherLabel.Text = "detailWeatherLabel";
            // 
            // weatherIconWeb
            // 
            this.weatherIconWeb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.weatherIconWeb.AllowNavigation = false;
            this.weatherIconWeb.AllowWebBrowserDrop = false;
            this.weatherIconWeb.CausesValidation = false;
            this.weatherIconWeb.Location = new System.Drawing.Point(7, 170);
            this.weatherIconWeb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherIconWeb.MinimumSize = new System.Drawing.Size(12, 12);
            this.weatherIconWeb.Name = "weatherIconWeb";
            this.weatherIconWeb.Size = new System.Drawing.Size(49, 38);
            this.weatherIconWeb.TabIndex = 4;
            // 
            // locationDistrictLabel
            // 
            this.locationDistrictLabel.AutoSize = true;
            this.locationDistrictLabel.Font = new System.Drawing.Font("Meiryo UI", 14F, System.Drawing.FontStyle.Bold);
            this.locationDistrictLabel.Location = new System.Drawing.Point(74, 132);
            this.locationDistrictLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationDistrictLabel.Name = "locationDistrictLabel";
            this.locationDistrictLabel.Size = new System.Drawing.Size(203, 30);
            this.locationDistrictLabel.TabIndex = 1;
            this.locationDistrictLabel.Text = "locationDistrict";
            // 
            // foodPicutrebox
            // 
            this.foodPicutrebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.foodPicutrebox.Location = new System.Drawing.Point(514, 206);
            this.foodPicutrebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foodPicutrebox.Name = "foodPicutrebox";
            this.foodPicutrebox.Size = new System.Drawing.Size(471, 453);
            this.foodPicutrebox.TabIndex = 0;
            this.foodPicutrebox.TabStop = false;
            // 
            // monthrecipelabel
            // 
            this.monthrecipelabel.AutoSize = true;
            this.monthrecipelabel.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthrecipelabel.Location = new System.Drawing.Point(513, 149);
            this.monthrecipelabel.Name = "monthrecipelabel";
            this.monthrecipelabel.Size = new System.Drawing.Size(72, 24);
            this.monthrecipelabel.TabIndex = 5;
            this.monthrecipelabel.Text = "label1";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Meiryo UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.datelabel.Location = new System.Drawing.Point(66, 14);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(207, 77);
            this.datelabel.TabIndex = 6;
            this.datelabel.Text = "label1";
            // 
            // weatherPictureBox
            // 
            this.weatherPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.weatherPictureBox.Location = new System.Drawing.Point(-8, 97);
            this.weatherPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.weatherPictureBox.Name = "weatherPictureBox";
            this.weatherPictureBox.Size = new System.Drawing.Size(74, 65);
            this.weatherPictureBox.TabIndex = 0;
            this.weatherPictureBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(673, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "レシピサイトを表示\r\n(ブラウザが開きます)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 659);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.monthrecipelabel);
            this.Controls.Add(this.weatherIconWeb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.detailWeatherLabel);
            this.Controls.Add(this.bodyLabal);
            this.Controls.Add(this.locationDistrictLabel);
            this.Controls.Add(this.locationPrefecturLabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.weatherPictureBox);
            this.Controls.Add(this.foodPicutrebox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicutrebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox weatherPictureBox;

        private System.Windows.Forms.PictureBox foodPicutrebox;

        private System.Windows.Forms.WebBrowser weatherIconWeb;

        private System.Windows.Forms.Label locationDistrictLabel;

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
    }
}