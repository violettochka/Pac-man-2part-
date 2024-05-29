using Pac_man_2part_.Base;
using Pac_man_2part_.console;
using Pac_man_2part_.enums;
using Pac_man_2part_.models;
namespace Pac_man_2part_
{
    public partial class frmPacMan : Form
    {
        Graphics g;
        GameBoardFields gameBoardEntity = new GameBoardFields();
        BaseEntity[,] field;
        UserConsole user;
        Pacman pacman;
        Coin coin;
        Wall wall;
        Helper helper;
        Ghost ghost;
        public frmPacMan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            field = gameBoardEntity.CreateGameBoard(ConsoleSettings.WIGTH,
                                                    ConsoleSettings.HEIGTH);
            user = new UserConsole();
            pacman = new Pacman(1, 1);
            coin = new Coin(0, 0);
            wall = new Wall(0, 0);
            helper = new Helper(0, 0);
            ghost = new Ghost(0, 0);
        }


        private void frmPacMan_Load(object sender, EventArgs e)
        {
            picGameBoard.Image = new Bitmap(ConsoleSettings.WIGTH * ConsoleSettings.PIXEL,
                                            ConsoleSettings.HEIGTH * ConsoleSettings.PIXEL);
            g = Graphics.FromImage(picGameBoard.Image);
            gameBoardEntity.CreateGameBoard(ConsoleSettings.WIGTH, ConsoleSettings.HEIGTH);
            gameBoardEntity.CreateBoard(field, g, imageList);
            field[pacman.X, pacman.Y] = pacman;

            wall.CreateWalls(25, 3, field);
            wall.DrawWalls(g, imageList, 3);

            coin.CreateCoins(50, field);
            coin.DrawCoins(g, imageList, 0);

            helper.CreateHelpers(3, field);
            helper.DrawHelpers(g, imageList, 2);

            ghost.CreateGhosts(4, field);
        }

        private void PacmanKeyDown(object sender, KeyEventArgs e)
        {
            pacman.Direction = user.ReadMovement(pacman.Direction, e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pacman.Clear(pacman.X, pacman.Y, g);
            pacman.Move(pacman.Direction, field);
            pacman.DrawImageDir(pacman, imagePacmanDir, g);
            picGameBoard.Refresh();
            CheckGameOver();

            ghost.ClearGhosts(g);
            ghost.RunGhosts(field);
            ghost.DrawGhosts(g, imageList, 1);
        }

        public void GameOver(string message, Pacman pacman)
        {
            MessageBox.Show($"{message}. Your score is {pacman.Score}");
        }

        public void CheckGameOver()
        {
            if (!ConsoleSettings.GameContinue)
            {
                timer.Enabled = false;
                GameOver("You lost", pacman);
                return;
            }
            if (ConsoleSettings.GameWin)
            {
                timer.Enabled = false;
                GameOver("You win", pacman);
                return;
            }
        }
    }
}


//        var wall = new Wall(0, 0);
//        for (int k = 1; k < 5; k++)
//        {
//            wall.CreateWall(5, gameboardfield);
//        }
//        foreach (var w in Wall.Walls)
//        {
//            foreach (var elem in w)
//            {
//                g.DrawImage(imageList.Images[3], elem.X * PIXELS, elem.Y * PIXELS);
//            }
//        }
//        var coin = new Coin(0, 0);
//        coin.CreateCoins(25, gameboardfield);
//        foreach (var c in Coin.coins)
//        {
//            g.DrawImage(imageList.Images[0], c.X * PIXELS, c.Y * PIXELS);
//        }
//    }

//    private void PacmanKeyDown(object sender, KeyEventArgs e)
//    {
//        switch (e.KeyCode)
//        {
//            case Keys.Up:
//                pacman.Direction = Direction.Up;
//                break;
//            case Keys.Down:
//                pacman.Direction = Direction.Down;
//                break;
//            case Keys.Left:
//                pacman.Direction = Direction.Left;
//                break;
//            case Keys.Right:
//                pacman.Direction = Direction.Right;
//                break;
//        }
//    }

//    private void TimerTick(object sender, EventArgs e)
//    {
//        g.FillRectangle(Brushes.White, pacman.X * PIXELS, pacman.Y * PIXELS, PIXELS, PIXELS);
//        pacman.Move(gameboardfield);
//        pacman.ChooseImageDir(pacman, imagePacmanDir, g);

//        g.FillRectangle(Brushes.White, cast1.X * PIXELS, cast1.Y * PIXELS, PIXELS, PIXELS);
//        cast1.Move(cast1.Direction, gameboardfield);
//        g.DrawImage(imageList.Images[1], cast1.X * 48, cast1.Y * 48);


//        g.FillRectangle(Brushes.White, cast2.X * PIXELS, cast2.Y * PIXELS, PIXELS, PIXELS);
//        cast2.Move(cast2.Direction, gameboardfield);
//        g.DrawImage(imageList.Images[1], cast2.X * 48, cast2.Y * 48);

//        picGameBoard.Refresh();

//        if (gameboardfield[pacman.X, pacman.Y ] == GameBoardFields.Wall)
//        {
//            GameOver();
//            picGameBoard.Refresh();
//        }
//        if (gameboardfield[pacman.X, pacman.Y] == GameBoardFields.Cast)
//        {
//            GameOver();
//            picGameBoard.Refresh();
//        }

//        if (gameboardfield[pacman.X, pacman.Y] == GameBoardFields.Coin)
//        {
//            pacman.score += 1;
//            gameboardfield[pacman.X, pacman.Y] = GameBoardFields.Free;
//            LabelScore.Text = "—чет: " + pacman.score.ToString();
//            picGameBoard.Refresh();
//        }

//        if (Coin.CountCoins == pacman.score)
//        {
//            GameWin();
//            picGameBoard.Refresh();
//        }

//    }


//    private void GameWin()
//    {
//        timer.Enabled = false;
//        MessageBox.Show("You win");
//    }

//    private void picGameBoard_Click(object sender, EventArgs e)
//    {

//    }
//}
//}
