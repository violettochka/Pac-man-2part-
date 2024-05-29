using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pac_man_2part_.Base;
using Pac_man_2part_.console;
using Pac_man_2part_.enums;

namespace Pac_man_2part_.models
{
    public class Wall : BaseEntity
    {
        public static readonly List<List<Wall>> Walls = new List<List<Wall>>();
        public Wall(int x, int y) : base(x, y)
        {
        }

        public override bool IsEmpty()
        {
            return false;
        }

        public override bool IsKilling()
        {
            return true;
        }
        public void CreateWalls(int countWall, int size, BaseEntity[,] field)
        {
            for (int j = 0; j < countWall; j++)
            {
                var block = new List<Wall>();
                var wall = GenerateEntity(field, (x, y) => new Wall(x, y));
                block.Add(wall);
                field[wall.X, wall.Y] = wall;
                for (int i = 1; i < size; i++)
                {
                    var currentwall = block.LastOrDefault();
                    if (!field[currentwall.X, currentwall.Y + 1].IsEmpty())
                    {
                        break;
                    }
                    var newWall = new Wall(currentwall.X, currentwall.Y + 1);
                    block.Add(newWall);
                    field[newWall.X, newWall.Y] = newWall;
                }
                Walls.Add(block);
            }
        }

        public void DrawWalls(Graphics g, ImageList image, int imageNumber)
        {
            foreach (var wall in Walls)
            {
                foreach (var block in wall)
                {
                    Draw(block.X, block.Y, g, image, imageNumber);
                }
            }
        }

        public override T GenerateEntity<T>(BaseEntity[,] field, EntityFactory<T> factory)
        {
            int randomX;
            int randomY;
            do
            {
                randomX = random.Next(2, ConsoleSettings.WIGTH - 2);
                randomY = random.Next(2, ConsoleSettings.HEIGTH - 2);
            } while (!field[randomX, randomY].IsEmpty() || !IsPositionValid(randomX, randomY, Walls));
            var entity = factory(randomX, randomY);
            field[randomX, randomY] = entity;
            return entity;
        }
        private bool IsPositionValid(int x, int y, List<List<Wall>> existingWalls)
        {
            foreach (var wall in existingWalls)
            {
                foreach(var block in wall)
                {
                    if (Math.Abs(x - block.X) <= 2 && Math.Abs(y - block.Y) <= 2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
