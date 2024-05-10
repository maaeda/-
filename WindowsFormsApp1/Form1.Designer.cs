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
            this.foodlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.morninglabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(473, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timelabel.Font = new System.Drawing.Font("Meiryo UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timelabel.Location = new System.Drawing.Point(124, 42);
            this.timelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(207, 77);
            this.timelabel.TabIndex = 1;
            this.timelabel.Text = "label1";
            // 
            // foodlabel
            // 
            this.foodlabel.AutoSize = true;
            this.foodlabel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.foodlabel.Location = new System.Drawing.Point(177, 154);
            this.foodlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodlabel.Name = "foodlabel";
            this.foodlabel.Size = new System.Drawing.Size(53, 19);
            this.foodlabel.TabIndex = 1;
            this.foodlabel.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // morninglabel
            // 
            this.morninglabel.AutoSize = true;
            this.morninglabel.Location = new System.Drawing.Point(481, 246);
            this.morninglabel.Name = "morninglabel";
            this.morninglabel.Size = new System.Drawing.Size(72, 15);
            this.morninglabel.TabIndex = 2;
            this.morninglabel.Text = "foods text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "朝の食事一覧";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.morninglabel);
            this.Controls.Add(this.foodlabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label foodlabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label morninglabel;
        private System.Windows.Forms.Button button1;
    }
}