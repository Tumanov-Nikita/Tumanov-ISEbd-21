using SecondLab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdLab
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			panel2.MouseDown += panelColor_MouseDown;
			panel3.MouseDown += panelColor_MouseDown;
			panel4.MouseDown += panelColor_MouseDown;
			panel5.MouseDown += panelColor_MouseDown;
			panel6.MouseDown += panelColor_MouseDown;
			panel7.MouseDown += panelColor_MouseDown;
			panel8.MouseDown += panelColor_MouseDown;
			panel9.MouseDown += panelColor_MouseDown;

			button2.Click += (object sender, EventArgs e) => { Close(); };
		}




			IAnimals animal = null;
			public IAnimals getAnimal { get { return animal; } }

			private void DrawRabbit()
			{
				if (animal != null)
				{
					Bitmap bmp = new Bitmap(pictureBoxAnimal.Width, pictureBoxAnimal.Height);
					Graphics gr = Graphics.FromImage(bmp);
					animal.setPosition(30, 50);
					animal.drawAnimal(gr);
					pictureBoxAnimal.Image = bmp;
				}
			}


		private event myDel eventAddAnimal;


		public void AddEvent(myDel ev)
		{
			if (eventAddAnimal == null)
			{
				eventAddAnimal = new myDel(ev);
			}
			else
			{
				eventAddAnimal += ev;
			}
		}


		


		private void label2_Click(object sender, EventArgs e)
		{

		}




		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			label1.DoDragDrop(label1.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void label2_MouseDown(object sender, MouseEventArgs e)
		{
			label2.DoDragDrop(label2.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}





		private void panelRabbit_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void panelRabbit_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Кролик":
					animal = new Rabbit(15, 15, 15, Color.Gray);
					break;
				case "Заяц":
					animal = new SportRabbit(20, 20, 20, Color.Gray, false, Color.LightSlateGray);
					break;

			}
			DrawRabbit();
		}






		private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Color)))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
		{
			if (animal !=null)
			{
				animal.setMainColor((Color)e.Data.GetData(typeof(Color)));
				DrawRabbit();
			}
		}




		private void panelColor_MouseDown (object sender, MouseEventArgs e)
		{
			(sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			if (animal != null)
			{
				if (animal != null)
				{
					if (animal is SportRabbit)
                {
						(animal as SportRabbit).setDopColor((Color)e.Data.GetData(typeof(Color)));
	DrawRabbit();
					}
				}

			
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (eventAddAnimal != null)
			{
				eventAddAnimal(animal);
			}
			Close();
		}

		private void labelRabbit_Click(object sender, EventArgs e)
		{

		}
	}
}
