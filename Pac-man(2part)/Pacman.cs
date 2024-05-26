using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pac_man_2part_.enums;
using System.Windows.Forms;

namespace Pac_man_2part_
{
    public class Pacman : BaseEntity
    {
        public int score;
        public Direction Direction { get; set; }
        public Pacman(int x, int y) : base(x, y)
        {
            Direction = Direction.Right;
            score = 0;
        }

        public void Move(GameBoardFields[,] gameboardfield)
        {
            gameboardfield[X, Y] = GameBoardFields.Free;
            switch (Direction)
            {
                case Direction.Right:
                    X++;
                    break;
                case Direction.Left:
                    X--;
                    break;
                case Direction.Down:
                    Y++;
                    break;
                case Direction.Up:
                    Y--;
                    break;
            }
            if(gameboardfield[X, Y] == GameBoardFields.Free)
            {
                gameboardfield[X, Y] = GameBoardFields.PacMan;
            }

        }
        public void ChooseImageDir(Pacman pacman,
                                   ImageList imagePacmanDir, 
                                   Graphics g)
        {
            switch (pacman.Direction)
            {
                case Direction.Left:
                    g.DrawImage(imagePacmanDir.Images[1], pacman.X * 48, pacman.Y * 48);
                    break;
                case Direction.Right:
                    g.DrawImage(imagePacmanDir.Images[3], pacman.X * 48, pacman.Y * 48);
                    break;
                case Direction.Up:
                    g.DrawImage(imagePacmanDir.Images[2], pacman.X * 48, pacman.Y * 48);
                    break;
                case Direction.Down:
                    g.DrawImage(imagePacmanDir.Images[0], pacman.X * 48, pacman.Y * 48);
                    break;
            }
        }
    }
}
