using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pac_man_2part_.console;
using Pac_man_2part_.enums;

namespace Pac_man_2part_.Base
{
    public class BaseEntity
    {
        public Random random;
        public delegate T EntityFactory<T>(int x, int y) where T : BaseEntity;
        public int X { get; set; }
        public int Y { get; set; }
        public BaseEntity(int x, int y)
        {
            X = x;
            Y = y;
            random = new Random();
        }

        public virtual bool IsKilling()
        {
            return false;
        }

        public virtual bool IsEmpty()
        {
            return true;
        }

        public void Draw(int x, int y, Graphics g, ImageList image, int imageNumber)
        {
            g.DrawImage(image.Images[imageNumber], 
                        x * ConsoleSettings.PIXEL, 
                        y * ConsoleSettings.PIXEL);
        }

        public void Clear(int x, int y, Graphics g)
        {
            g.FillRectangle(Brushes.Black, 
                            x * ConsoleSettings.PIXEL, 
                            y * ConsoleSettings.PIXEL,
                            ConsoleSettings.PIXEL, 
                            ConsoleSettings.PIXEL);
        }



        public virtual T GenerateEntity<T>(BaseEntity[,] field, EntityFactory<T> factory) where T : BaseEntity
        {
            int randomX;
            int randomY;
            do
            {
                randomX = random.Next(2, ConsoleSettings.WIGTH - 2);
                randomY = random.Next(2, ConsoleSettings.HEIGTH - 2);
            } while (!field[randomX, randomY].IsEmpty());
            var entity = factory(randomX, randomY);
            field[randomX, randomY] = entity;
            return entity;
        }
    }
}
