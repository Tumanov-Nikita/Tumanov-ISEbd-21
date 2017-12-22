using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
	public interface IAnimals
	{
		void moveAnimal(Graphics g);

		void drawAnimal(Graphics g);

		void setPosition(int x, int y);

		void hide(bool hidely);

		void eat(); 
	}
}
