using SecondLab;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
    class TakingPlace
    {
        List<ClassArray<IAnimals>> takingPLace;

        int countPlaces = 15;
        int placeSizeWidth = 210;
        int placeSizeHeight = 120;
		int currentLevel;
		public int getCurrentLevel { get { return currentLevel; } }

		public TakingPlace(int levels)
		{
			takingPLace = new List<ClassArray<IAnimals>>();
			for (int i = 0; i < levels; i++)
			{
				takingPLace.Add(new ClassArray<IAnimals>(countPlaces, null));
			}
		}

		public void LevelUp()
		{
			if (currentLevel + 1 < takingPLace.Count)
			{
				currentLevel++;
			}
		}

		public void LevelDown()
		{
			if (currentLevel > 0)
			{
				currentLevel--;
			}
		}

		public int PutAnimalInPlace(IAnimals animal)
        {
            return takingPLace[currentLevel]+animal;
        }

        public IAnimals GetAnimalInPlace(int ticket)
        {
            return takingPLace[currentLevel] - ticket;
        }

        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i=0; i<countPlaces; i++)
            {
                var animal = takingPLace[currentLevel][i];
                if (animal != null)
                {
                    animal.setPosition(5 + i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight + 45);
                    animal.drawAnimal(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
			g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue), (countPlaces / 5) * placeSizeWidth, 480);


            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 600);
            for (int i = 0;i< countPlaces/5; i++)
            {
                for (int j=0; j<6; j++)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
					if (j < 5)
					{
						g.DrawString((i*5+j+1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i*placeSizeWidth+30, j*placeSizeHeight+20);

					}
				}
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 600);
            }
        }
    }
}
