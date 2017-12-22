namespace SecondLab
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
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.buttonSelectDopColor = new System.Windows.Forms.Button();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxMaxCountFood = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDraw
            // 
            this.pictureBoxDraw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxDraw.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.Size = new System.Drawing.Size(835, 312);
            this.pictureBoxDraw.TabIndex = 0;
            this.pictureBoxDraw.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MaxSpeed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "MaxCountFood:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Color:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Заяц";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Кролик";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(652, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Движение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSelectColor.Location = new System.Drawing.Point(277, 377);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(78, 28);
            this.buttonSelectColor.TabIndex = 10;
            this.buttonSelectColor.Text = "Color";
            this.buttonSelectColor.UseVisualStyleBackColor = false;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // buttonSelectDopColor
            // 
            this.buttonSelectDopColor.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonSelectDopColor.Location = new System.Drawing.Point(507, 377);
            this.buttonSelectDopColor.Name = "buttonSelectDopColor";
            this.buttonSelectDopColor.Size = new System.Drawing.Size(78, 28);
            this.buttonSelectDopColor.TabIndex = 11;
            this.buttonSelectDopColor.Text = "DopColor";
            this.buttonSelectDopColor.UseVisualStyleBackColor = false;
            this.buttonSelectDopColor.Click += new System.EventHandler(this.buttonSelectDopColor_Click);
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(90, 340);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(86, 20);
            this.textBoxMaxSpeed.TabIndex = 12;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(90, 382);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(86, 20);
            this.textBoxWeight.TabIndex = 13;
            // 
            // textBoxMaxCountFood
            // 
            this.textBoxMaxCountFood.Location = new System.Drawing.Point(324, 339);
            this.textBoxMaxCountFood.Name = "textBoxMaxCountFood";
            this.textBoxMaxCountFood.Size = new System.Drawing.Size(86, 20);
            this.textBoxMaxCountFood.TabIndex = 14;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(616, 340);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Спрятаться";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 489);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBoxMaxCountFood);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.buttonSelectDopColor);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxDraw;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button buttonSelectColor;
		private System.Windows.Forms.Button buttonSelectDopColor;
		private System.Windows.Forms.TextBox textBoxMaxSpeed;
		private System.Windows.Forms.TextBox textBoxWeight;
		private System.Windows.Forms.TextBox textBoxMaxCountFood;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

