using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pac_man_2part_.Base;
using Pac_man_2part_.models;

namespace Pac_man_2part_.console
{
    public class GameBoardFields
    {
        public BaseEntity[,] CreateGameBoard(int width, int heigth)
        {
            BaseEntity[,] field = new BaseEntity[width, heigth];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < heigth; y++)
                {
                    field[x, y] = new BaseEntity(x, y);
                }
            }
            return field;
        }

        public void CreateBoard(BaseEntity[,] field, Graphics g, ImageList imageList)
        {

            for (int x = 0; x < field.GetLength(0); x++)
            {
                field[x, 0] = new Wall(x, 0);
                g.DrawImage(imageList.Images[3], x * ConsoleSettings.PIXEL, 0);

                field[x, ConsoleSettings.HEIGTH - 1] = new Wall(x, ConsoleSettings.HEIGTH - 1);
                g.DrawImage(imageList.Images[3],
                            x * ConsoleSettings.PIXEL,
                            (ConsoleSettings.HEIGTH - 1) * ConsoleSettings.PIXEL);
            }

            for (int y = 0; y < field.GetLength(1); y++)
            {
                field[0, y] = new Wall(0, y);
                g.DrawImage(imageList.Images[3], 0, y * ConsoleSettings.PIXEL);

                field[ConsoleSettings.WIGTH - 1, y] = new Wall(ConsoleSettings.WIGTH - 1, y);
                g.DrawImage(imageList.Images[3],
                           (ConsoleSettings.WIGTH - 1) * ConsoleSettings.PIXEL,
                           y * ConsoleSettings.PIXEL);
            }
        }
    }
}
