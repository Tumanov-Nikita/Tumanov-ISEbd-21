using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
	class SportRabbit : Rabbit, IComparable<SportRabbit>, IEquatable<Rabbit>
    { 
        private Color dopColor;
        private Color color;
        bool hidely;      

        public int  CompareTo(SportRabbit other)
        {
            var res = (this is Rabbit).CompareTo(other is Rabbit);
            if (res != 0)
            {
                return res;
            }
            if (hidely != other.hidely)
            {
                return hidely.CompareTo(other.hidely);
            }
            if (dopColor != other.dopColor)
            {
                dopColor.Name.CompareTo(other.dopColor.Name);
            }
            return 0;
        }

        public bool Equals(SportRabbit other)
        {
            var res = (this is Rabbit).Equals(other is Rabbit);
            if (!res)
            {
                return res;
            }
            if (hidely != other.hidely)
            {
                return false;
            }
            if (dopColor != other.dopColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            SportRabbit rabbitObj = obj as SportRabbit;
            if (rabbitObj == null)
            {
                return false;
            }
            else
            {
                return Equals(rabbitObj);
            }
        }

        public override int GetHashCode()
        {            
                return base.GetHashCode();        
        }


        public override int MaxSpeed
		{
			get
			{
				return base.MaxSpeed;
			}

			protected set
			{
				if (value > 0 && value < 10)
				{
					base.MaxSpeed = value;
				}
				else
				{
					base.MaxSpeed = 8;
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
				if (value > 3 && value < 7)
				{
					base.Weight = value;
				}
				else
				{
					base.MaxSpeed = 5;
				}
			}
		}



		public SportRabbit (int maxSpeed, int maxCountFood, double weight, Color color, bool hidely, Color dopColor) :base(maxSpeed, maxCountFood, weight, color)
		{
            this.hidely = hidely;
            this.dopColor = dopColor;
            this.color = color;
        }

		public SportRabbit(string info) : base (info)
		{
			string[] strs = info.Split(';');
			if (strs.Length == 6)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				MaxCountFood = Convert.ToInt32(strs[1]);
				Weight = Convert.ToInt32(strs[2]);
				ColorBody = Color.FromName(strs[3]);
				hidely = Convert.ToBoolean(strs[4]);
				dopColor = Color.FromName(strs[5]);
			}
		}


		protected override void drawLightAnimal(Graphics g)
		{		
           
              Pen pen = new Pen(Color.Black);

            Brush br = new SolidBrush(dopColor);
            g.FillEllipse(br, startPosX + 86, startPosY + 37, 14, 10);
            g.DrawEllipse(pen, startPosX + 86, startPosY + 37, 14, 10);
            base.drawLightAnimal(g);
            pen = new Pen(Color.White);
            br = new SolidBrush(Color.White);
            if (hidely)
            {
                g.FillEllipse(br, startPosX + 18, startPosY + 4, 10, -25); 
                g.DrawEllipse(pen, startPosX + 18, startPosY + 4, 10, -25);
            }
 
                       
            Pen p = new Pen(Color.Black);
            Brush bru = new SolidBrush(ColorBody);
            if (hidely)
            {
                g.FillEllipse(bru, startPosX + 18, startPosY - 3, 40, 10);
                g.DrawEllipse(p, startPosX + 18, startPosY - 3, 40, 10);
            }
            else
            {
                g.FillEllipse(bru, startPosX + 18, startPosY + 5, 10, -40);
                g.DrawEllipse(p, startPosX + 18, startPosY + 5, 10, -40);
            }
          
            Brush b = new SolidBrush(dopColor);
          
            g.FillEllipse(b, startPosX + 6, startPosY + 6, 5, 5);

             p = new Pen(Color.Black);
             bru = new SolidBrush(ColorBody);
            g.FillEllipse(bru, startPosX + 55, startPosY + 30, 30, 24);
            g.DrawEllipse(p, startPosX + 55, startPosY + 30, 30, 24);
        }


		public virtual void setDopColor(Color color)
		{
			dopColor = color;
		}


		public override string getInfo()
		{
			return MaxSpeed + ";" + MaxCountFood + ";" + Weight + ";" + ColorBody.Name +
				";" + hidely + ";" + dopColor.Name;
		}

	}
}
