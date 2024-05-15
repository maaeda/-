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
            this.titleLabal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.morninglabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bodyLabal = new System.Windows.Forms.Label();
            this.detailWeatherLabel = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(853, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timelabel.Font = new System.Drawing.Font("Meiryo UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timelabel.Location = new System.Drawing.Point(202, 67);
            this.timelabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(329, 122);
            this.timelabel.TabIndex = 1;
            this.timelabel.Text = "label1";
            // 
            // titleLabal
            // 
            this.titleLabal.AutoSize = true;
            this.titleLabal.Font = new System.Drawing.Font("Meiryo UI", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabal.Location = new System.Drawing.Point(120, 211);
            this.titleLabal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabal.Name = "titleLabal";
            this.titleLabal.Size = new System.Drawing.Size(208, 48);
            this.titleLabal.TabIndex = 1;
            this.titleLabal.Text = "titleLabal";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // morninglabel
            // 
            this.morninglabel.AutoSize = true;
            this.morninglabel.Location = new System.Drawing.Point(871, 409);
            this.morninglabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.morninglabel.Name = "morninglabel";
            this.morninglabel.Size = new System.Drawing.Size(110, 24);
            this.morninglabel.TabIndex = 2;
            this.morninglabel.Text = "foods text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(835, 343);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "朝の食事一覧";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bodyLabal
            // 
            this.bodyLabal.Font = new System.Drawing.Font("Meiryo UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bodyLabal.Location = new System.Drawing.Point(32, 343);
            this.bodyLabal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bodyLabal.Name = "bodyLabal";
            this.bodyLabal.Size = new System.Drawing.Size(739, 496);
            this.bodyLabal.TabIndex = 1;
            this.bodyLabal.Text = "bodyLabal";
            // 
            // detailWeatherLabel
            // 
            this.detailWeatherLabel.AutoSize = true;
            this.detailWeatherLabel.Font = new System.Drawing.Font("Meiryo UI", 14F, System.Drawing.FontStyle.Bold);
            this.detailWeatherLabel.Location = new System.Drawing.Point(120, 284);
            this.detailWeatherLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.detailWeatherLabel.Name = "detailWeatherLabel";
            this.detailWeatherLabel.Size = new System.Drawing.Size(411, 48);
            this.detailWeatherLabel.TabIndex = 1;
            this.detailWeatherLabel.Text = "detailWeatherLabel";
            // 
            // webBrowser1
            // 
            this.webBrowser1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.CausesValidation = false;
            this.webBrowser1.Location = new System.Drawing.Point(12, 272);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(80, 60);
            this.webBrowser1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 899);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.morninglabel);
            this.Controls.Add(this.detailWeatherLabel);
            this.Controls.Add(this.bodyLabal);
            this.Controls.Add(this.titleLabal);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label bodyLabal;
        private System.Windows.Forms.Label detailWeatherLabel;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label titleLabal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label morninglabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}