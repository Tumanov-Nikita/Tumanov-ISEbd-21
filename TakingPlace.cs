using SecondLab;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
			return takingPLace[currentLevel] + animal;
		}

		public IAnimals GetAnimalInPlace(int ticket)
		{
			return takingPLace[currentLevel] - ticket;
		}

		public void Draw(Graphics g, int width, int height)
		{
			DrawMarking(g);
			for (int i = 0; i < countPlaces; i++)
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
			for (int i = 0; i < countPlaces / 5; i++)
			{
				for (int j = 0; j < 6; j++)
				{
					g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
					if (j < 5)
					{
						g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i * placeSizeWidth + 30, j * placeSizeHeight + 20);

					}
				}
				g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 600);
			}
		}


		public bool SaveData(string filename)
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (FileStream fs = new FileStream(filename, FileMode.Create))
			{
				using (BufferedStream bs = new BufferedStream(fs))
				{
					byte[] info = new UTF8Encoding(true).GetBytes("CountLevels:" + takingPLace.Count + Environment.NewLine);
					fs.Write(info, 0, info.Length);
					foreach (var level in takingPLace)
					{
						info = new UTF8Encoding(true).GetBytes("Level" + takingPLace.Count + Environment.NewLine);
						fs.Write(info, 0, info.Length);
						for (int i = 0; i < countPlaces; i++)
						{
							var animal = level[i];
							if (animal != null)
							{
								if (animal.GetType().Name == "Rabbit")
								{
									info = new UTF8Encoding(true).GetBytes("Rabbit:");
									fs.Write(info, 0, info.Length);
								}
								if (animal.GetType().Name == "SportRabbit")
								{
									info = new UTF8Encoding(true).GetBytes("SportRabbit:");
									fs.Write(info, 0, info.Length);
								}
								info = new UTF8Encoding(true).GetBytes(animal.getInfo() + Environment.NewLine);
								fs.Write(info, 0, info.Length);
							}
						}
					}
				}

			}
			return true;
		}




		public bool LoadData(string filename)
		{
			if (!File.Exists(filename))
			{
				return false;
			}
			using (FileStream fs = new FileStream(filename, FileMode.Open))
			{
				string s = "";
				using (BufferedStream bs = new BufferedStream(fs))
				{
					byte[] b = new byte[fs.Length];
					UTF8Encoding temp = new UTF8Encoding(true);
					while (bs.Read(b, 0, b.Length) > 0)
					{
						s += temp.GetString(b);
					}
				}
				s = s.Replace("\r", "");
				var strs = s.Split('\n');
				if (strs[0].Contains("CountLevels"))
				{
					int count = Convert.ToInt32(strs[0].Split(':')[1]);
					if (takingPLace != null)
					{
						takingPLace.Clear();
					}
					takingPLace = new List<ClassArray<IAnimals>>(count);
				}
				else
				{
					return false;
				}
				int counter = -1;
				for (int i=1; i<strs.Length; i++)
				{
					if (strs[i] == "Level5")
					{
						counter++;
						takingPLace.Add(new ClassArray<IAnimals>(countPlaces, null));
					}
					else if (strs[i].Split(':')[0] == "Rabbit"){
						IAnimals animal = new Rabbit(strs[i].Split(':')[1]);
						int number = takingPLace[counter] + animal;
						if (number == -1)
						{
							return false;
						}
					}
					else if (strs[i].Split(':')[0] == "SportRabbit")
					{
						IAnimals animal = new SportRabbit(strs[i].Split(':')[1]);
						int number = takingPLace[counter] + animal;
						if (number == -1)
						{
							return false;
						}
					}
				}
			}
			return true;
		}


	}
}
