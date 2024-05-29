using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pac_man_2part_.enums;
using System.Windows.Forms;
using Pac_man_2part_.Base;
using Pac_man_2part_.console;

namespace Pac_man_2part_.models
{
    public class Pacman : MovebleEntity
    {
        public int Score { get; set; }
        public Pacman(int x, int y) : base(x, y)
        {
            Score = 0;
            Direction = Direction.None;
        }
        public override bool IsEmpty()
        {
            return false;
        }
        public void Move(Direction direction, BaseEntity[,] field)
        {
            Direction = direction;
            var newCoordinates = SwitchDirection(direction, this);
            PacmanIsKilling(field, newCoordinates.Item1, newCoordinates.Item2);
            TakeCoin(field, newCoordinates.Item1, newCoordinates.Item2);
            TakeHelper(newCoordinates.Item1, newCoordinates.Item2, field);
            RewriteEntity(field, newCoordinates.Item1, newCoordinates.Item2, this);
        }

        public void DrawImageDir(Pacman pacman,
                                   ImageList imagePacmanDir,
                                   Graphics g)
        {

            int imageIndex = pacman.Direction switch
            {
                Direction.Left => 1,
                Direction.Right => 3,
                Direction.Up => 2,
                Direction.Down => 0,
                _ => 3
            };

            pacman.Draw(pacman.X, pacman.Y, g, imagePacmanDir, imageIndex);
        }

        public void PacmanIsKilling(BaseEntity[,] field, int x, int y)
        {
            if (field[x, y].IsKilling())
            {
                ConsoleSettings.GameContinue = false;
            }
        }

        public void TakeCoin(BaseEntity[,] field, int x, int y)
        {
            if (field[x, y] is Coin)
            {
                Score++;
                if(Score == Coin.CountCoins)
                {
                    ConsoleSettings.GameWin = true;
                }
            }
        }

        public void TakeHelper(int x, int y, BaseEntity[,] field)
        {
            if (field[x, y] is Helper)
            {
                var ghost = Ghost.ghosts.FirstOrDefault();
                Ghost.ghosts.Remove(ghost);
            }
        }
    }
}
