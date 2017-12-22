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
    public partial class FormTakingPlace : Form
    {
        TakingPlace takingPlace;
		Form2 form;


        public FormTakingPlace()
        {
            InitializeComponent();
            takingPlace = new TakingPlace(5);
			for (int i = 1; i < 6; i++)
			{
				listBoxLevels.Items.Add("Уровень " + i);
			}
			listBoxLevels.SelectedIndex = takingPlace.getCurrentLevel;

			Draw();

        }

        private void Draw()
        {
			if (listBoxLevels.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
				Graphics gr = Graphics.FromImage(bmp);
				takingPlace.Draw(gr, pictureBox1.Width, pictureBox1.Height);
				pictureBox1.Image = bmp;
			}
        }



        private void FormTakingPlace_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var animal = new Rabbit(100, 4, 1000, dialog.Color);
                int place = takingPlace.PutAnimalInPlace(animal);
                Draw();
                MessageBox.Show("Ваше место: " + place);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var animal = new SportRabbit(100, 4, 1000, dialog.Color, false, dialogDop.Color);
                    int place = takingPlace.PutAnimalInPlace(animal);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
			if (listBoxLevels.SelectedIndex > -1)
			{//Прежде чем забрать машину, надо выбрать с какого уровня будем забирать
				string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
				if (maskedTextBox1.Text != "")
				{
					IAnimals car = takingPlace.GetAnimalInPlace(Convert.ToInt32(maskedTextBox1.Text));
					if (car != null)
					{//если удалось забрать, то отрисовываем
						Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
						Graphics gr = Graphics.FromImage(bmp);
						car.setPosition(5, 40);
						car.drawAnimal(gr);
						pictureBox1.Image = bmp;
						Draw();
					}
					else
					{//иначесообщаемобэтом
						MessageBox.Show("Извинте, на этом месте нет зайки");
					}
				}
			}
		


	}

	private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			takingPlace.LevelDown();
			listBoxLevels.SelectedIndex = takingPlace.getCurrentLevel;
			Draw();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			takingPlace.LevelUp();
			listBoxLevels.SelectedIndex = takingPlace.getCurrentLevel;
			Draw();

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			form = new ThirdLab.Form2();
			form.AddEvent(AddAnimal);
			form.Show();

			//form = new Form2();
			//form.ShowDialog();
			//var animal = form.getAnimal;
			//if (animal != null)
			//{
			//	int place = takingPlace.PutAnimalInPlace(animal);
			//	if (place > -1)
			//	{
			//		Draw();
			//		MessageBox.Show("Ваше место: " + place);
			//	}
			//	else
			//	{
			//		MessageBox.Show("Животное не удалось поместить");
			//	}
			//}
		}

		private void AddAnimal(IAnimals animal)
		{
			if (animal != null)
			{
				int place = takingPlace.PutAnimalInPlace(animal);
				if (place > -1)
				{
					Draw();
							MessageBox.Show("Ваше место: " + place);
					}
						else
						{
							MessageBox.Show("Животное не удалось поместить");
						}
				}
			}
	}
}