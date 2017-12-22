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

        public FormTakingPlace()
        {
            InitializeComponent();
            takingPlace = new TakingPlace();
            Draw();

        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            takingPlace.Draw(gr, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
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
            if (maskedTextBox1.Text != "")
            {
                var animal = takingPlace.GetAnimalInPlace(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                animal.setPosition(5, 40);
                animal.drawAnimal(gr);
                pictureBox2.Image = bmp;
                Draw();
            }

        }
    }
}