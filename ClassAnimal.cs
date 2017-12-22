using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
	public abstract class ClassAnimal:IAnimals
	{
		protected float startPosX;

		protected float startPosY;

		protected int countFood;

		public virtual int MaxCountFood { protected set; get; }

		public virtual int MaxSpeed { protected set; get; }

		public Color ColorBody { protected set; get; }

		public virtual double Weight { protected set; get; }

		public abstract void moveAnimal(Graphics g);

		public abstract void drawAnimal(Graphics g);

		public void setPosition(int x, int y) {
			startPosX = x;
			startPosY = y;
		}

		public void hide(bool hidely)
		{
			hidely = !hidely;
		}

		public void eat() {
			countFood++;
		} 

	}
}
