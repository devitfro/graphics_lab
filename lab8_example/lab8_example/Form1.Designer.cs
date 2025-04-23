namespace lab8_example
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trackBar_Brightness = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_Contrast = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.redBrigtnessText = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.blueBrigtnessText = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.greenBrigtnessText = new System.Windows.Forms.Label();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(170, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 320);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(103, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "open";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(421, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(660, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "to gray color";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Gray_color);
            // 
            // trackBar_Brightness
            // 
            this.trackBar_Brightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.trackBar_Brightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Brightness.Location = new System.Drawing.Point(671, 162);
            this.trackBar_Brightness.Maximum = 100;
            this.trackBar_Brightness.Name = "trackBar_Brightness";
            this.trackBar_Brightness.Size = new System.Drawing.Size(214, 50);
            this.trackBar_Brightness.TabIndex = 4;
            this.trackBar_Brightness.TickFrequency = 10;
            this.trackBar_Brightness.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(675, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "brightness:";
            // 
            // trackBar_Contrast
            // 
            this.trackBar_Contrast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.trackBar_Contrast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Contrast.Location = new System.Drawing.Point(671, 274);
            this.trackBar_Contrast.Maximum = 100;
            this.trackBar_Contrast.Name = "trackBar_Contrast";
            this.trackBar_Contrast.Size = new System.Drawing.Size(214, 50);
            this.trackBar_Contrast.TabIndex = 6;
            this.trackBar_Contrast.TickFrequency = 10;
            this.trackBar_Contrast.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(675, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "contrast:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // redBrigtnessText
            // 
            this.redBrigtnessText.AutoSize = true;
            this.redBrigtnessText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redBrigtnessText.ForeColor = System.Drawing.Color.Navy;
            this.redBrigtnessText.Location = new System.Drawing.Point(993, 45);
            this.redBrigtnessText.Name = "redBrigtnessText";
            this.redBrigtnessText.Size = new System.Drawing.Size(177, 25);
            this.redBrigtnessText.TabIndex = 9;
            this.redBrigtnessText.Text = "(Red) brightness:";
            this.redBrigtnessText.Click += new System.EventHandler(this.label3_Click);
            // 
            // trackBarRed
            // 
            this.trackBarRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.trackBarRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarRed.Location = new System.Drawing.Point(996, 81);
            this.trackBarRed.Maximum = 100;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(214, 50);
            this.trackBarRed.TabIndex = 8;
            this.trackBarRed.TickFrequency = 10;
            this.trackBarRed.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // blueBrigtnessText
            // 
            this.blueBrigtnessText.AutoSize = true;
            this.blueBrigtnessText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueBrigtnessText.ForeColor = System.Drawing.Color.Navy;
            this.blueBrigtnessText.Location = new System.Drawing.Point(993, 155);
            this.blueBrigtnessText.Name = "blueBrigtnessText";
            this.blueBrigtnessText.Size = new System.Drawing.Size(181, 25);
            this.blueBrigtnessText.TabIndex = 13;
            this.blueBrigtnessText.Text = "(Blue) brightness:";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trackBarBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarBlue.Location = new System.Drawing.Point(996, 183);
            this.trackBarBlue.Maximum = 100;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(214, 50);
            this.trackBarBlue.TabIndex = 12;
            this.trackBarBlue.TickFrequency = 10;
            this.trackBarBlue.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // greenBrigtnessText
            // 
            this.greenBrigtnessText.AutoSize = true;
            this.greenBrigtnessText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenBrigtnessText.ForeColor = System.Drawing.Color.Navy;
            this.greenBrigtnessText.Location = new System.Drawing.Point(993, 256);
            this.greenBrigtnessText.Name = "greenBrigtnessText";
            this.greenBrigtnessText.Size = new System.Drawing.Size(197, 25);
            this.greenBrigtnessText.TabIndex = 17;
            this.greenBrigtnessText.Text = "(Green) brightness:";
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trackBarGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarGreen.Location = new System.Drawing.Point(996, 295);
            this.trackBarGreen.Maximum = 100;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(214, 50);
            this.trackBarGreen.TabIndex = 16;
            this.trackBarGreen.TickFrequency = 10;
            this.trackBarGreen.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(848, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 70);
            this.button4.TabIndex = 18;
            this.button4.Text = "variant 14";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.v14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1313, 801);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.greenBrigtnessText);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.blueBrigtnessText);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.redBrigtnessText);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar_Contrast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_Brightness);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar trackBar_Brightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_Contrast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label redBrigtnessText;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Label blueBrigtnessText;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label greenBrigtnessText;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.Button button4;
    }
}

