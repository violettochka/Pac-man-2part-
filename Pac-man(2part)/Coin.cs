using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pac_man_2part_.enums;

namespace Pac_man_2part_
{
    public class Coin : BaseEntity
    {
        public static readonly List<Coin> coins = new List<Coin>();
        public Random random = new Random();
        public static int CountCoins;
        public Coin(int x, int y) : base(x, y)
        {
        }

        public void CreateCoins(int count, GameBoardFields[,] gameboardfields)
        {
            for (int i = 0; i < count; i++)
            {
                var randomX = random.Next(1, 21); // Только нечетные значения
                var randomY = random.Next(1, 13);
                while (gameboardfields[randomX, randomY] != GameBoardFields.Free)
                {
                    randomX = random.Next(1, 21); // Только нечетные значения
                    randomY = random.Next(1, 13);
                }
                var coin = new Coin(randomX, randomY);
                coins.Add(coin);
                gameboardfields[randomX, randomY] = GameBoardFields.Coin;
            }
            CountCoins = coins.Count;
        }
    }
}
