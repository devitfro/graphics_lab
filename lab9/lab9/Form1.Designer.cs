namespace lab9
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReflectOX = new System.Windows.Forms.Button();
            this.buttonScale = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Indigo;
            this.flowLayoutPanel1.Controls.Add(this.buttonRefresh);
            this.flowLayoutPanel1.Controls.Add(this.buttonReflectOX);
            this.flowLayoutPanel1.Controls.Add(this.buttonScale);
            this.flowLayoutPanel1.Controls.Add(this.buttonRotate);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1041, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(101, 241);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::lab9.Properties.Resources.refresh;
            this.buttonRefresh.Location = new System.Drawing.Point(3, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 46);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonReflectOX
            // 
            this.buttonReflectOX.Font = new System.Drawing.Font("Microsoft YaHei", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReflectOX.ForeColor = System.Drawing.Color.Navy;
            this.buttonReflectOX.Location = new System.Drawing.Point(3, 55);
            this.buttonReflectOX.Name = "buttonReflectOX";
            this.buttonReflectOX.Size = new System.Drawing.Size(96, 56);
            this.buttonReflectOX.TabIndex = 7;
            this.buttonReflectOX.Text = "OX";
            this.buttonReflectOX.UseVisualStyleBackColor = true;
            this.buttonReflectOX.Click += new System.EventHandler(this.buttonReflectOX_Click);
            // 
            // buttonScale
            // 
            this.buttonScale.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonScale.ForeColor = System.Drawing.Color.Navy;
            this.buttonScale.Location = new System.Drawing.Point(3, 117);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(96, 56);
            this.buttonScale.TabIndex = 8;
            this.buttonScale.Text = "Scale";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // button3
            // 
            this.button3.Image = global::lab9.Properties.Resources.bell_ring;
            this.button3.Location = new System.Drawing.Point(3, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 46);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::lab9.Properties.Resources.thumbtack;
            this.button1.Location = new System.Drawing.Point(3, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::lab9.Properties.Resources.stars;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 46);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Navy;
            this.textBox1.Location = new System.Drawing.Point(840, 542);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 49);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Indigo;
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1038, 314);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(103, 156);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // buttonRotate
            // 
            this.buttonRotate.Font = new System.Drawing.Font("Microsoft YaHei", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRotate.ForeColor = System.Drawing.Color.Navy;
            this.buttonRotate.Image = global::lab9.Properties.Resources.rotate_right;
            this.buttonRotate.Location = new System.Drawing.Point(3, 179);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(96, 56);
            this.buttonRotate.TabIndex = 9;
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(843, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter value to rotate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 771);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonReflectOX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Label label1;
    }
}

