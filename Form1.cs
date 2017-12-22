using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstLab
{
    public partial class Form1 : Form
    {

        private Egg[] eggs;
        private Salt salt;
        private WaterTap waterTap;
        private Knife knife;
        private Pan pan;
        private Stove stove;
        private Milk[] milk;

        public Form1()
        {
            InitializeComponent();
            waterTap = new WaterTap();
            knife = new Knife();
            pan = new Pan();
            stove = new Stove();
        }

        //private void Form1_Load(object sender, EventArgs e)

        //{



        //}

        private void ButtonEggsAdd_Click(object sender, EventArgs e)
        {


            if (eggs == null)
            {
                Egg t = new Egg();


                eggs = new Egg[Convert.ToInt32(numericUpDown1.Value)];
                //  t.countEggs = Convert.ToInt32(numericUpDown1.Value);
                for (int i = 0; i < Convert.ToInt32(numericUpDown1.Value); i++)
                {

                    eggs[i] = new Egg();
                }

                MessageBox.Show("Яйца взяли", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("У вас уже есть яйца", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Dirty > 0)
                {
                    MessageBox.Show("Яйца грязные!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (eggs[i].Have_shell)
                {
                    MessageBox.Show("Яйца со скорлупой!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Яйца добавили, можно на плиту", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ButtonSaltAdd_Click(object sender, EventArgs e)
        {
            Salt salt = new Salt();
            salt.CountSalt = Convert.ToInt32(numericUpDown2.Value);
            if (salt.CountSalt > 0)
            {
                pan.AddSalt(salt);
                MessageBox.Show("Соль взяли", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Соли же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonMilkAdd_Click(object sender, EventArgs e)
        {

            if (milk == null)
            {
                Milk t = new Milk();
                milk = new Milk[Convert.ToInt32(numericUpDown2.Value)];



                for (int i = 0; i < Convert.ToInt32(numericUpDown2.Value); i++)
                {
                    milk[i] = new Milk();
                }

                MessageBox.Show("Молоко взяли", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("У вас уже есть молоко", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);


            //for (int i = 0; i < milk.Length; ++i)
            //{
            //    pan.AddMilk(milk[i]);
            //}
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                waterTap.State = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                waterTap.State = false;
            }
        }



        private void ButtonWash_Click(object sender, EventArgs e)
        {

            if (numericUpDown1.Value > 0)

            {

                if (!waterTap.State)

                {

                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }

                eggs = new Egg[Convert.ToInt32(numericUpDown1.Value)];

                pan.Init(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));

                for (int i = 0; i < eggs.Length; ++i)

                {

                    eggs[i] = new Egg();

                }

                for (int i = 0; i < eggs.Length; ++i)

                {

                    eggs[i].Dirty = 0;

                }

                numericUpDown1.Enabled = false;

                radioButton2.Checked = true;

                MessageBox.Show("Яйца помыли", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else

            {

                MessageBox.Show("Яиц то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ButtonSmash_Click(object sender, EventArgs e)
        {
            if (eggs == null)
            {
                MessageBox.Show("Яиц то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (eggs.Length == 0)
            {
                MessageBox.Show("Яиц то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Dirty > 0)
                {
                    MessageBox.Show("Яйца грязные!!! Помыть бы их сначала", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                knife.Smash(eggs[i]);
            }
     
            MessageBox.Show("Скорлупу разбили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ButtonCook_Click(object sender, EventArgs e)
        {
            stove.Pan = pan;
            if (!pan.ReadyToGo) 
            {
                MessageBox.Show("У нас не все готово к варке!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!stove.State)
            {
                MessageBox.Show("Варить собрались энергией космоса или все же включим плиту?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          if (pan.IsReady()==false)
            stove.Cook();
            if (stove.Pan.IsReady())
            {
                ButtonGetRez.Enabled = true;
                MessageBox.Show("Приготовилась!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так, омлет не получился", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ButtonGetRez_Click(object sender, EventArgs e)
        {
            eggs = pan.GetEggs();
            MessageBox.Show("Мы сделали это! Приятного аппетита!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BowlSalt_Click(object sender, EventArgs e)
        {

            pan.AddSalt(salt);

            MessageBox.Show("Добавили соль", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BowlMilk_Click(object sender, EventArgs e)
        {
            if (milk == null)
            {
                MessageBox.Show("Молока нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (milk.Length == 0)
            {
                MessageBox.Show("Молока нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < milk.Length; ++i)
            {
                pan.AddMilk(milk[i]);
            }
            //   buttonAddPotatos.Enabled = true;
            MessageBox.Show("Залили молоко", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BowlEgg_Click(object sender, EventArgs e)
        {
            if (eggs == null)
            {
                MessageBox.Show("Яиц нет, что закидывать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (eggs.Length == 0)
            {
                MessageBox.Show("Яиц нет, что закидывать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Dirty > 0)
                {
                    MessageBox.Show("Яйца грязные!!! Помыть бы их сначала", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Have_shell)
                {
                    MessageBox.Show("Не разбили скорлупу", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                pan.AddEggs(eggs[i]);
            }
            //   buttonAddPotatos.Enabled = true;
            MessageBox.Show("Яйца добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = !stove.State;
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Плита включена", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonCook.Enabled = true;
            }
            else MessageBox.Show("Плита выключена", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < eggs.Length; ++i)
            {
                eggs[i].Mixed = true;               
            }
            MessageBox.Show("Перемешали", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
