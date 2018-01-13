

        ﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
	public class Rabbit:ClassAnimal
	{
		public override int MaxSpeed
		{
			get
			{
				return base.MaxSpeed;
			}

			protected set
			{
				if (value >0 && value< 7)
				{
					base.MaxSpeed = value;
				}
				else
				{
					base.MaxSpeed = 5;
				}
			}
		}





		public override int MaxCountFood
		{
			get
			{
				return base.MaxCountFood;
			}

			protected set
			{
				if (value > 0 && value < 10)
				{
					base.MaxCountFood = value;
				}
				else
				{
					base.MaxCountFood = 7;
				}
			}
		}

		public override double Weight
		{
			get
			{
				return base.Weight;
			}

			protected set
			{
				if (value > 5 && value < 10)
				{
					base.Weight = value;
				}
				else
				{
					base.Weight = 7;
				}
			}
		}

		public Rabbit(int maxSpeed, int maxCountGrass, double weight, Color color )
		{
			this.MaxSpeed = maxSpeed;
			this.MaxCountFood = maxCountGrass;
			this.ColorBody = color;
			this.Weight = weight;
			Random rand = new Random();
			startPosX = rand.Next(10, 200);
			startPosY = rand.Next(10, 200);
		}

		public override void moveAnimal(Graphics g)
		{
			startPosX +=
				(MaxSpeed * 50 / (float)Weight) /
				(countFood == 0 ? 1 : countFood);
			drawAnimal(g);
		}

		public override void drawAnimal(Graphics g)
		{
			drawLightAnimal(g);
		}

		protected virtual void drawLightAnimal(Graphics g)
		{
            Pen pen = new Pen(Color.Tan); //лапы
            Brush br = new SolidBrush(Color.Tan);
            for (int i=0, a=0 ; i<10; i++, a++)
            {
                g.DrawLine(pen, startPosX + 25+a, startPosY + 25, startPosX + 25+a, startPosY + 60);
            }

            for (int i = 0, a = 0; i < 15; i++, a++)//задние лапы
            {
                g.DrawLine(pen, startPosX + 50 + a, startPosY + 25, startPosX + 80 + a, startPosY + 56);
            }

            for (int i = 0, a = 0; i < 15; i++, a++)
            {
                g.DrawLine(pen, startPosX + 80 + a, startPosY + 56, startPosX + 60 + a, startPosY + 63);
            }

            pen = new Pen(Color.Black);
            g.DrawLine(pen, startPosX + 50, startPosY + 25, startPosX + 80, startPosY + 56);
            g.DrawLine(pen, startPosX + 65, startPosY + 25, startPosX + 95, startPosY + 56);
            g.DrawLine(pen, startPosX + 80, startPosY + 56, startPosX +60, startPosY + 63);
            g.DrawLine(pen, startPosX + 95, startPosY + 56, startPosX + 75, startPosY + 63);
            g.DrawLine(pen, startPosX + 25, startPosY + 25, startPosX + 25, startPosY + 63);
            g.DrawLine(pen, startPosX + 35, startPosY + 25, startPosX + 35, startPosY + 63);
            g.FillEllipse(br, startPosX + 58, startPosY + 57, 20, 10);
            g.DrawEllipse(pen, startPosX + 58, startPosY + 57, 20, 10);
            g.FillEllipse(br, startPosX + 15, startPosY + 57, 20, 10);
            g.DrawEllipse(pen, startPosX + 15, startPosY + 57,20 ,10 );
            pen = new Pen(Color.Black);
            br = new SolidBrush(ColorBody);

            g.FillEllipse(br, startPosX + 14, startPosY + 6, 40, 20);//шея
            g.DrawEllipse(pen, startPosX + 14, startPosY + 6, 40, 20);
            g.FillEllipse(br, startPosX + 18, startPosY + 11, 40, 25);
            g.DrawEllipse(pen, startPosX + 18, startPosY + 11, 40, 25);
            g.FillEllipse(br, startPosX + 25, startPosY + 10, 70, 40);//туловище
            g.DrawEllipse(pen, startPosX + 25, startPosY + 10, 70, 40);


            g.FillEllipse(br, startPosX + 60, startPosY + 33, 25, 20);
            g.DrawEllipse(pen, startPosX + 60, startPosY + 33, 25, 20);



            g.FillEllipse(br, startPosX + 18, startPosY+4, 10, -25); //уши
            g.DrawEllipse(pen, startPosX + 18, startPosY+4, 10, -25);

            g.FillEllipse(br,startPosX, startPosY, 33,20 );//голова
            g.DrawEllipse(pen, startPosX, startPosY, 33, 20);


            br = new SolidBrush(Color.Black);//глаза
            g.DrawEllipse(pen, startPosX+7, startPosY+7, 3, 3);

            
           

          
        }
	}
}
