using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pac_man_2part_.enums;

namespace Pac_man_2part_.console
{
    public class UserConsole
    {
        public Direction ReadMovement(Direction currentDirection, KeyEventArgs e)
        {
            currentDirection = e.KeyCode switch
            {
                Keys.Up => Direction.Up,
                Keys.Down => Direction.Down,
                Keys.Left => Direction.Left,
                Keys.Right => Direction.Right,
                _ => currentDirection
            };

            return currentDirection;
        }
    }
}

