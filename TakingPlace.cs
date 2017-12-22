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
        ClassArray<IAnimals> takingPLace;

        int countPlaces = 15;
        int placeSizeWidth = 210;
        int placeSizeHeight = 120;

        public TakingPlace()
        {
            takingPLace = new ClassArray<IAnimals>(countPlaces, null);
        }

        public int PutAnimalInPlace(IAnimals animal)
        {
            return takingPLace + animal;
        }

        public IAnimals GetAnimalInPlace(int ticket)
        {
            return takingPLace - ticket;
        }

        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i=0; i<countPlaces; i++)
            {
                var animal = takingPLace.getObject(i);
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
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 600);
            for (int i = 0;i< countPlaces/5; i++)
            {
                for (int j=0; j<6; j++)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 600);
            }
        }
    }
}
