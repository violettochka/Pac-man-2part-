using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pac_man_2part_.Base;
using Pac_man_2part_.enums;

namespace Pac_man_2part_.models
{
    public class Coin : BaseEntity
    {
        public static readonly List<Coin> coins = new List<Coin>();
        public static int CountCoins;
        public Coin(int x, int y) : base(x, y)
        {
        }
        public override bool IsEmpty()
        {
            return false;
        }

        public void CreateCoins(int count, BaseEntity[,] gameboardfields)
        {
            for (int i = 0; i < count; i++)
            {
                var coin = GenerateEntity(gameboardfields, (x, y) => new Coin(x, y));
                coins.Add(coin);
            }
            CountCoins = coins.Count;
        }

        public void DrawCoins(Graphics g, ImageList image, int imageNumber)
        {
            foreach (var coin in coins)
            {
                coin.Draw(coin.X, coin.Y, g, image, imageNumber);
            }
        }
    }
}
