using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pac_man_2part_.enums;

namespace Pac_man_2part_
{
    public class Wall : BaseEntity
    {
        public static readonly List<List<Wall>> Walls = new List<List<Wall>>();
        public Random random;
        public Wall(int x, int y) : base(x, y)
        {
            random = new Random();
        }
        public void CreateWall(int size, GameBoardFields[,] gameboardfield)
        {
            var block = new List<Wall>();

            var randomX = random.Next(1, 11) * 2 + 1; // Только нечетные значения
            var randomY = random.Next(1, 5) * 2;
            while (gameboardfield[randomX, randomY] == GameBoardFields.Wall)
            {
                randomX = random.Next(1, 11) * 2 + 1;
                randomY = random.Next(1, 5) * 2;
            }
            block.Add(new Wall(randomX, randomY));
            gameboardfield[randomX, randomY] = GameBoardFields.Wall;
            for(int i = 1; i < size; i++)
            {
                var currentwall = block.LastOrDefault();

                    block.Add(new Wall(currentwall.X, currentwall.Y + 1));
                    gameboardfield[currentwall.X, (currentwall.Y + 1)] = GameBoardFields.Wall;
            }
            Walls.Add(block);
        }
    }
}
