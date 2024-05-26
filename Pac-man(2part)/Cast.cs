using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pac_man_2part_.enums;

namespace Pac_man_2part_
{
    public class Cast : BaseEntity
    {
        public Direction Direction { get; set; }
        public Random random = new Random();
        public Cast(int x, int y) : base(x, y)
        {
            Direction = Direction.Right;
        }

        private bool CanMoveInDirection(Direction direction, GameBoardFields[,] gameboardfield)
        {
            int nextX = X;
            int nextY = Y;

            switch (direction)
            {
                case Direction.Right:
                    nextX = X + 1;
                    break;
                case Direction.Left:
                    nextX = X - 1;
                    break;
                case Direction.Down:
                    nextY = Y + 1;
                    break;
                case Direction.Up:
                    nextY = Y - 1;
                    break;
            }

            if (gameboardfield[nextX,nextY] == GameBoardFields.Coin ||
                gameboardfield[nextX,nextY] == GameBoardFields.Wall)

            {
                return false;
            }

            return true;
        }

        public void Move(Direction direction, GameBoardFields[,] gameboardfield)
        {

            if (!CanMoveInDirection(direction, gameboardfield))
            {
                int enumLength = Enum.GetValues(typeof(Direction)).Length;
                int randomIndex;
                do
                {
                    randomIndex = random.Next(0, enumLength);
                } while ((Direction)randomIndex == direction);

                direction = (Direction)randomIndex;
                while (!CanMoveInDirection(direction, gameboardfield))
                {
                    randomIndex = random.Next(0, enumLength);

                    direction = (Direction)randomIndex;
                }
            }
            gameboardfield[X, Y] = GameBoardFields.Free;
            switch (direction)
            {
                case Direction.Right:
                    X = X + 1;
                    break;
                case Direction.Left:
                    X = X - 1;
                    break;
                case Direction.Down:
                    Y = Y + 1;
                    break;
                case Direction.Up:
                    Y = Y - 1;
                    break;
            }
            gameboardfield[X, Y] = GameBoardFields.Cast;
            Direction = direction;

        }
    }
}
