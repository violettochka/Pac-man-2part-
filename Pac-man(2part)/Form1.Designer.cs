namespace Pac_man_2part_
{
    partial class frmPacMan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacMan));
            picGameBoard = new PictureBox();
            imageList = new ImageList(components);
            timer = new System.Windows.Forms.Timer(components);
            imagePacmanDir = new ImageList(components);
            LabelScore = new Label();
            ((System.ComponentModel.ISupportInitialize)picGameBoard).BeginInit();
            SuspendLayout();
            // 
            // picGameBoard
            // 
            picGameBoard.BackColor = SystemColors.Window;
            picGameBoard.Location = new Point(12, 12);
            picGameBoard.Name = "picGameBoard";
            picGameBoard.Size = new Size(1056, 672);
            picGameBoard.TabIndex = 0;
            picGameBoard.TabStop = false;
            picGameBoard.Click += picGameBoard_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "coin.png");
            imageList.Images.SetKeyName(1, "ghost.png");
            imageList.Images.SetKeyName(2, "helper.png");
            imageList.Images.SetKeyName(3, "wall.png");
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 250;
            timer.Tick += TimerTick;
            // 
            // imagePacmanDir
            // 
            imagePacmanDir.ColorDepth = ColorDepth.Depth32Bit;
            imagePacmanDir.ImageStream = (ImageListStreamer)resources.GetObject("imagePacmanDir.ImageStream");
            imagePacmanDir.TransparentColor = Color.Transparent;
            imagePacmanDir.Images.SetKeyName(0, "pacman-blue(down).png");
            imagePacmanDir.Images.SetKeyName(1, "pacman-blue(left).png");
            imagePacmanDir.Images.SetKeyName(2, "pacman-blue(up).png");
            imagePacmanDir.Images.SetKeyName(3, "pacman-blue(right).png");
            // 
            // LabelScore
            // 
            LabelScore.AutoSize = true;
            LabelScore.Location = new Point(83, 51);
            LabelScore.Name = "LabelScore";
            LabelScore.Size = new Size(50, 20);
            LabelScore.TabIndex = 1;
            LabelScore.Text = "label1";
            // 
            // frmPacMan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 710);
            Controls.Add(LabelScore);
            Controls.Add(picGameBoard);
            Name = "frmPacMan";
            Text = "form1";
            Load += frmPacMan_Load;
            KeyDown += PacmanKeyDown;
            ((System.ComponentModel.ISupportInitialize)picGameBoard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picGameBoard;
        private ImageList imageList;
        private System.Windows.Forms.Timer timer;
        private ImageList imagePacmanDir;
        private Label LabelScore;
    }
}
