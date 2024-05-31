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
        int GameLevel;
        string PlayerColor;

        int NumberOfWalls;
        int NumberOfCoins;
        int NumberOfGhosts;
        int NumberOfHelpers;

        public frmPacMan()
        {
            using (Form2 settingsForm = new Form2())
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    GameLevel = settingsForm.Level;
                    PlayerColor = settingsForm.Color;

                    InitializeGame(GameLevel, PlayerColor);
                }
                else
                {
                    this.Close();
                }
            }
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

        public void ChooseLevel(int level)
        {
            switch(level)
            {
                case 1:
                    NumberOfWalls = 15;
                    NumberOfCoins = 25;
                    NumberOfGhosts = 2;
                    NumberOfHelpers = 1;
                    break;
                case 2:
                    NumberOfWalls = 20;
                    NumberOfCoins = 35;
                    NumberOfGhosts = 3;
                    NumberOfHelpers = 1;
                    break;
                case 3:
                    NumberOfWalls = 25;
                    NumberOfCoins = 45;
                    NumberOfGhosts = 5;
                    NumberOfHelpers = 2;
                    break;
            }
        }

        public void ChooseColor(string color)
        {
            switch (color)
            {
                case "Blue":
                    Pacman.ImagePacmanDir = imagePacmanDirBlue;
                    break;
                case "White":
                    Pacman.ImagePacmanDir = imagePacmanDirWhite;
                    break;
                case "Pink":
                    Pacman.ImagePacmanDir = imagePacmanDirPink;
                    break;
            }
        }

        private void InitializeGame(int level, string color)
        {
            GameLevel = level;
            ChooseLevel(GameLevel);
            PlayerColor = color;
            ChooseColor(PlayerColor);

        }

        private void frmPacMan_Load(object sender, EventArgs e)
        {
            InitializeGame(GameLevel, PlayerColor);
            picGameBoard.Image = new Bitmap(ConsoleSettings.WIGTH * ConsoleSettings.PIXEL,
                                            ConsoleSettings.HEIGTH * ConsoleSettings.PIXEL);
            g = Graphics.FromImage(picGameBoard.Image);
            gameBoardEntity.CreateGameBoard(ConsoleSettings.WIGTH, ConsoleSettings.HEIGTH);
            gameBoardEntity.CreateBoard(field, g, imageList);
            field[pacman.X, pacman.Y] = pacman;

            wall.CreateWalls(NumberOfWalls, 3, field);
            wall.DrawWalls(g, imageList, 3);

            coin.CreateCoins(NumberOfCoins, field);
            coin.DrawCoins(g, imageList, 0);

            helper.CreateHelpers(NumberOfHelpers, field);
            helper.DrawHelpers(g, imageList, 2);

            ghost.CreateGhosts(NumberOfGhosts, field);
        }



        private void PacmanKeyDown(object sender, KeyEventArgs e)
        {
            pacman.Direction = user.ReadMovement(pacman.Direction, e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pacman.Clear(pacman.X, pacman.Y, g);
            pacman.Move(pacman.Direction, field);
            pacman.DrawImageDir(pacman, g);
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
