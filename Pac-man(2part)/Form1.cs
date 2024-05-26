using Pac_man_2part_.enums;
namespace Pac_man_2part_
{
    public partial class frmPacMan : Form
    {
        Graphics g;
        Pacman pacman = new Pacman(3, 3);
        Cast cast1 = new Cast(2, 12);
        Cast cast2 = new Cast(20, 2);
        GameBoardFields[,] gameboardfield;
        public const int PIXELS = 48;
        public frmPacMan()
        {
            InitializeComponent();
            gameboardfield = new GameBoardFields[22, 14];
        }


        private void frmPacMan_Load(object sender, EventArgs e)
        {
            picGameBoard.Image = new Bitmap(1056, 672);
            g = Graphics.FromImage(picGameBoard.Image);


            for (int i = 0; i < 22; i++)
            {
                g.DrawImage(imageList.Images[3], i * PIXELS, 0);
                gameboardfield[i, 0] = GameBoardFields.Wall;
                g.DrawImage(imageList.Images[3], i * PIXELS, 624);
                gameboardfield[i, 13] = GameBoardFields.Wall;
            }

            for (int i = 1; i < 14; i++)
            {
                g.DrawImage(imageList.Images[3], 0, i * PIXELS);
                gameboardfield[0, i] = GameBoardFields.Wall;
                g.DrawImage(imageList.Images[3], 1008, i * PIXELS);
                gameboardfield[21, i] = GameBoardFields.Wall;
            }
            var wall = new Wall(0, 0);
            for (int k = 1; k < 5; k++)
            {
                wall.CreateWall(5, gameboardfield);
            }
            foreach (var w in Wall.Walls)
            {
                foreach (var elem in w)
                {
                    g.DrawImage(imageList.Images[3], elem.X * PIXELS, elem.Y * PIXELS);
                }
            }
            var coin = new Coin(0, 0);
            coin.CreateCoins(25, gameboardfield);
            foreach (var c in Coin.coins)
            {
                g.DrawImage(imageList.Images[0], c.X * PIXELS, c.Y * PIXELS);
            }
        }

        private void PacmanKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    pacman.Direction = Direction.Up;
                    break;
                case Keys.Down:
                    pacman.Direction = Direction.Down;
                    break;
                case Keys.Left:
                    pacman.Direction = Direction.Left;
                    break;
                case Keys.Right:
                    pacman.Direction = Direction.Right;
                    break;
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            g.FillRectangle(Brushes.White, pacman.X * PIXELS, pacman.Y * PIXELS, PIXELS, PIXELS);
            pacman.Move(gameboardfield);
            pacman.ChooseImageDir(pacman, imagePacmanDir, g);

            g.FillRectangle(Brushes.White, cast1.X * PIXELS, cast1.Y * PIXELS, PIXELS, PIXELS);
            cast1.Move(cast1.Direction, gameboardfield);
            g.DrawImage(imageList.Images[1], cast1.X * 48, cast1.Y * 48);


            g.FillRectangle(Brushes.White, cast2.X * PIXELS, cast2.Y * PIXELS, PIXELS, PIXELS);
            cast2.Move(cast2.Direction, gameboardfield);
            g.DrawImage(imageList.Images[1], cast2.X * 48, cast2.Y * 48);

            picGameBoard.Refresh();

            if (gameboardfield[pacman.X, pacman.Y ] == GameBoardFields.Wall)
            {
                GameOver();
                picGameBoard.Refresh();
            }
            if (gameboardfield[pacman.X, pacman.Y] == GameBoardFields.Cast)
            {
                GameOver();
                picGameBoard.Refresh();
            }

            if (gameboardfield[pacman.X, pacman.Y] == GameBoardFields.Coin)
            {
                pacman.score += 1;
                gameboardfield[pacman.X, pacman.Y] = GameBoardFields.Free;
                LabelScore.Text = "—чет: " + pacman.score.ToString();
                picGameBoard.Refresh();
            }

            if (Coin.CountCoins == pacman.score)
            {
                GameWin();
                picGameBoard.Refresh();
            }

        }

        private void GameOver()
        {
            timer.Enabled = false;
            MessageBox.Show("Game over!");
        }

        private void GameWin()
        {
            timer.Enabled = false;
            MessageBox.Show("You win");
        }

        private void picGameBoard_Click(object sender, EventArgs e)
        {

        }
    }
}
