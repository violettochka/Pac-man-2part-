using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pac_man_2part_.Base;
using Pac_man_2part_.enums;

namespace Pac_man_2part_.models
{
    public class Ghost : MovebleEntity
    {
        public static readonly List<Ghost> ghosts = new List<Ghost>();
        public Ghost(int x, int y) : base(x, y)
        {
            Direction = Direction.Right;
        }
        public override bool IsKilling()
        {
            return true;
        }

        public override bool IsEmpty()
        {
            return false;
        }

        private bool CanMove(Direction direction, BaseEntity[,] field)
        {
            var newCoordinates = SwitchDirection(direction, this);

            return field[newCoordinates.Item1, newCoordinates.Item2].IsEmpty();
        }

        public void Move(Direction direction, BaseEntity[,] field)
        {
            while (!CanMove(direction, field))
            {
                int enumLength = Enum.GetValues(typeof(Direction)).Length;
                int randomIndex = random.Next(1, enumLength);
                direction = (Direction)randomIndex;
            }
            var newCoordinates = SwitchDirection(direction, this);
            Direction = direction;
            RewriteEntity(field, newCoordinates.Item1, newCoordinates.Item2, this);
        }

        public void CreateGhosts(int quantity, BaseEntity[,] field)
        {
            var random = new Random();
            for (int i = 0; i < quantity; i++)
            {
                var ghost = GenerateEntity(field, (x, y) => new Ghost(x, y));
                ghosts.Add(ghost);
            }
        }
        public void RunGhosts(BaseEntity[,] field)
        {
            foreach (var ghost in ghosts)
            {
                ghost.Move(ghost.Direction, field);
            }
        }

        public void ClearGhosts(Graphics g)
        {
            foreach (var ghost in ghosts)
            {
                Clear(ghost.X, ghost.Y, g);
            }
        }

        public void DrawGhosts(Graphics g, ImageList image, int imageNumber)
        {
            foreach (var ghost in ghosts)
            {
                ghost.Draw(ghost.X, ghost.Y, g, image, imageNumber);
            }
        }
    

    //private bool CanMoveInDirection(Direction direction, GameBoardFields[,] gameboardfield)
    //{
    //    int nextX = X;
    //    int nextY = Y;

    //    switch (direction)
    //    {
    //        case Direction.Right:
    //            nextX = X + 1;
    //            break;
    //        case Direction.Left:
    //            nextX = X - 1;
    //            break;
    //        case Direction.Down:
    //            nextY = Y + 1;
    //            break;
    //        case Direction.Up:
    //            nextY = Y - 1;
    //            break;
    //    }

    //    if (gameboardfield[nextX, nextY] == GameBoardFields.Coin ||
    //        gameboardfield[nextX, nextY] == GameBoardFields.Wall)

    //    {
    //        return false;
    //    }

    //    return true;
    //}

    //public void Move(Direction direction, GameBoardFields[,] gameboardfield)
    //{

    //    if (!CanMoveInDirection(direction, gameboardfield))
    //    {
    //        int enumLength = Enum.GetValues(typeof(Direction)).Length;
    //        int randomIndex;
    //        do
    //        {
    //            randomIndex = random.Next(0, enumLength);
    //        } while ((Direction)randomIndex == direction);

    //        direction = (Direction)randomIndex;
    //        while (!CanMoveInDirection(direction, gameboardfield))
    //        {
    //            randomIndex = random.Next(0, enumLength);

    //            direction = (Direction)randomIndex;
    //        }
    //    }

    //    gameboardfield[X, Y] = GameBoardFields.Free;
    //    switch (direction)
    //    {
    //        case Direction.Right:
    //            X = X + 1;
    //            break;
    //        case Direction.Left:
    //            X = X - 1;
    //            break;
    //        case Direction.Down:
    //            Y = Y + 1;
    //            break;
    //        case Direction.Up:
    //            Y = Y - 1;
    //            break;
    //    }
    //    gameboardfield[X, Y] = GameBoardFields.Cast;
    //    Direction = direction;

    //}
}
}
