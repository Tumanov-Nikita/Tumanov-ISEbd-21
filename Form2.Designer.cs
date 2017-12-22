namespace ThirdLab
{
	partial class Form2
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
			this.pictureBoxAnimal = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.labelBaseColor = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxAnimal
			// 
			this.pictureBoxAnimal.Location = new System.Drawing.Point(29, 9);
			this.pictureBoxAnimal.Name = "pictureBoxAnimal";
			this.pictureBoxAnimal.Size = new System.Drawing.Size(175, 186);
			this.pictureBoxAnimal.TabIndex = 0;
			this.pictureBoxAnimal.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(97, 96);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Кролик/заяц";
			// 
			// label1
			// 
			this.label1.AllowDrop = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(18, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Кролик";
			this.label1.Click += new System.EventHandler(this.labelRabbit_Click);
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			// 
			// label2
			// 
			this.label2.AllowDrop = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(18, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Заяц";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 175);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(13, 220);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel9);
			this.groupBox2.Controls.Add(this.panel8);
			this.groupBox2.Controls.Add(this.panel7);
			this.groupBox2.Controls.Add(this.panel6);
			this.groupBox2.Controls.Add(this.panel5);
			this.groupBox2.Controls.Add(this.panel4);
			this.groupBox2.Controls.Add(this.panel3);
			this.groupBox2.Controls.Add(this.panel2);
			this.groupBox2.Location = new System.Drawing.Point(373, 47);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(115, 261);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Цвета";
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.Red;
			this.panel9.Location = new System.Drawing.Point(65, 173);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(35, 32);
			this.panel9.TabIndex = 1;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Silver;
			this.panel8.Location = new System.Drawing.Point(15, 173);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(35, 32);
			this.panel8.TabIndex = 1;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.panel7.Location = new System.Drawing.Point(65, 128);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(35, 32);
			this.panel7.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.panel6.Location = new System.Drawing.Point(15, 128);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(35, 32);
			this.panel6.TabIndex = 3;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Blue;
			this.panel5.Location = new System.Drawing.Point(65, 78);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(35, 32);
			this.panel5.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Yellow;
			this.panel4.Location = new System.Drawing.Point(15, 78);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(35, 32);
			this.panel4.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Black;
			this.panel3.Location = new System.Drawing.Point(65, 29);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(35, 32);
			this.panel3.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel2.Location = new System.Drawing.Point(15, 29);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(35, 32);
			this.panel2.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.AllowDrop = true;
			this.panel1.Controls.Add(this.labelDopColor);
			this.panel1.Controls.Add(this.labelBaseColor);
			this.panel1.Controls.Add(this.pictureBoxAnimal);
			this.panel1.Location = new System.Drawing.Point(115, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(228, 311);
			this.panel1.TabIndex = 5;
			this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelRabbit_DragDrop);
			this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelRabbit_DragEnter);
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(57, 249);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(100, 23);
			this.labelDopColor.TabIndex = 2;
			this.labelDopColor.Text = "Dop Color";
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// labelBaseColor
			// 
			this.labelBaseColor.AllowDrop = true;
			this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBaseColor.Location = new System.Drawing.Point(57, 208);
			this.labelBaseColor.Name = "labelBaseColor";
			this.labelBaseColor.Size = new System.Drawing.Size(100, 23);
			this.labelBaseColor.TabIndex = 1;
			this.labelBaseColor.Text = "Main Color";
			this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
			this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 336);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxAnimal;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.Label labelBaseColor;
	}
}