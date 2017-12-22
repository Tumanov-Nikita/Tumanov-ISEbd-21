using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLab
{
	public partial class Form1 : Form
	{
        Color color;
        Color dopColor;
        int MaxSpeed;
        int MaxCountFood;
        int weight;

        private IAnimals inter;
        public Form1()
		{
			InitializeComponent();
            color = Color.DarkGray;
            dopColor = Color.AliceBlue;
            MaxSpeed = 25;
            MaxCountFood = 10;
            weight = 7;
            buttonSelectColor.BackColor = color;
            buttonSelectDopColor.BackColor = dopColor;
        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
		{
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                buttonSelectColor.BackColor = color;
            }
        }

        private bool checkFields()
        {
            if (!int.TryParse(textBoxMaxSpeed.Text, out MaxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBoxMaxCountFood.Text, out MaxCountFood))
            {
                return false;
            }
            if (!int.TryParse(textBoxWeight.Text, out weight))
            {
                return false;
            }
            return true;
        }



        private void button2_Click(object sender, EventArgs e)
        {
          if (checkFields())
            {
                inter = new Rabbit(MaxSpeed, MaxCountFood, weight, color);
                Bitmap bmp = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawAnimal(gr);
                pictureBoxDraw.Image = bmp;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new SportRabbit(70, 7, 5, color, checkBox2.Checked, dopColor);
                Bitmap bmp = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawAnimal(gr);
                pictureBoxDraw.Image = bmp;
            } 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSelectDopColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                buttonSelectDopColor.BackColor = dopColor;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveAnimal(gr);
                pictureBoxDraw.Image = bmp;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
