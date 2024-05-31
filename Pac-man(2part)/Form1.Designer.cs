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
            imagePacmanDirBlue = new ImageList(components);
            imagePacmanDirPink = new ImageList(components);
            imagePacmanDirWhite = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)picGameBoard).BeginInit();
            SuspendLayout();
            // 
            // picGameBoard
            // 
            picGameBoard.BackColor = SystemColors.WindowText;
            picGameBoard.Location = new Point(12, 12);
            picGameBoard.Name = "picGameBoard";
            picGameBoard.Size = new Size(1296, 960);
            picGameBoard.TabIndex = 0;
            picGameBoard.TabStop = false;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "coin.png");
            imageList.Images.SetKeyName(1, "ghost.png");
            imageList.Images.SetKeyName(2, "helper.png");
            imageList.Images.SetKeyName(3, "2672702_wall_object_essential_app_ux_icon.png");
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 250;
            timer.Tick += timer_Tick;
            // 
            // imagePacmanDirBlue
            // 
            imagePacmanDirBlue.ColorDepth = ColorDepth.Depth32Bit;
            imagePacmanDirBlue.ImageStream = (ImageListStreamer)resources.GetObject("imagePacmanDirBlue.ImageStream");
            imagePacmanDirBlue.TransparentColor = Color.Transparent;
            imagePacmanDirBlue.Images.SetKeyName(0, "pacman-blue(down).png");
            imagePacmanDirBlue.Images.SetKeyName(1, "pacman-blue(left).png");
            imagePacmanDirBlue.Images.SetKeyName(2, "pacman-blue(up).png");
            imagePacmanDirBlue.Images.SetKeyName(3, "pacman-blue(right).png");
            // 
            // imagePacmanDirPink
            // 
            imagePacmanDirPink.ColorDepth = ColorDepth.Depth32Bit;
            imagePacmanDirPink.ImageStream = (ImageListStreamer)resources.GetObject("imagePacmanDirPink.ImageStream");
            imagePacmanDirPink.TransparentColor = Color.Transparent;
            imagePacmanDirPink.Images.SetKeyName(0, "pacman-purpleUp(3).png");
            imagePacmanDirPink.Images.SetKeyName(1, "pacman-purpleUp94).png");
            imagePacmanDirPink.Images.SetKeyName(2, "pacman-purple.png");
            imagePacmanDirPink.Images.SetKeyName(3, "pacman-purpleUp.png");
            // 
            // imagePacmanDirWhite
            // 
            imagePacmanDirWhite.ColorDepth = ColorDepth.Depth32Bit;
            imagePacmanDirWhite.ImageStream = (ImageListStreamer)resources.GetObject("imagePacmanDirWhite.ImageStream");
            imagePacmanDirWhite.TransparentColor = Color.Transparent;
            imagePacmanDirWhite.Images.SetKeyName(0, "(3).png");
            imagePacmanDirWhite.Images.SetKeyName(1, "381603_pacman_icon.png");
            imagePacmanDirWhite.Images.SetKeyName(2, "(4]).png");
            imagePacmanDirWhite.Images.SetKeyName(3, "381603_pacman_icon(2).png");
            // 
            // frmPacMan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(1162, 823);
            Controls.Add(picGameBoard);
            Name = "frmPacMan";
            Text = "form1";
            Load += frmPacMan_Load;
            KeyDown += PacmanKeyDown;
            ((System.ComponentModel.ISupportInitialize)picGameBoard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picGameBoard;
        private ImageList imageList;
        private System.Windows.Forms.Timer timer;
        private ImageList imagePacmanDirBlue;
        private ImageList imagePacmanDirPink;
        private ImageList imagePacmanDirWhite;
    }
}
