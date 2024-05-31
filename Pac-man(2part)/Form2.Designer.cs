namespace Pac_man_2part_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameOfTheGame = new Label();
            NameLevel = new Label();
            NameColor = new Label();
            LevelEasy = new Button();
            LevelMedium = new Button();
            LevelHard = new Button();
            ColorBlue = new Button();
            ColorWhite = new Button();
            ColorPink = new Button();
            StartGame = new Button();
            SuspendLayout();
            // 
            // NameOfTheGame
            // 
            NameOfTheGame.AutoSize = true;
            NameOfTheGame.BackColor = SystemColors.InactiveCaptionText;
            NameOfTheGame.Font = new Font("Stencil", 20F, FontStyle.Bold);
            NameOfTheGame.ForeColor = SystemColors.ControlLightLight;
            NameOfTheGame.Location = new Point(290, 20);
            NameOfTheGame.Name = "NameOfTheGame";
            NameOfTheGame.Size = new Size(270, 40);
            NameOfTheGame.TabIndex = 0;
            NameOfTheGame.Text = "Pac Man Game";
            // 
            // NameLevel
            // 
            NameLevel.AutoSize = true;
            NameLevel.Font = new Font("Stencil", 15F);
            NameLevel.ForeColor = SystemColors.ButtonHighlight;
            NameLevel.Location = new Point(128, 110);
            NameLevel.Name = "NameLevel";
            NameLevel.Size = new Size(92, 30);
            NameLevel.TabIndex = 1;
            NameLevel.Text = "Level:";
            // 
            // NameColor
            // 
            NameColor.AutoSize = true;
            NameColor.Font = new Font("Stencil", 15F);
            NameColor.ForeColor = SystemColors.ButtonHighlight;
            NameColor.Location = new Point(128, 241);
            NameColor.Name = "NameColor";
            NameColor.Size = new Size(98, 30);
            NameColor.TabIndex = 2;
            NameColor.Text = "Color:";
            // 
            // LevelEasy
            // 
            LevelEasy.Font = new Font("Stencil", 10F);
            LevelEasy.Location = new Point(254, 87);
            LevelEasy.Name = "LevelEasy";
            LevelEasy.Size = new Size(84, 83);
            LevelEasy.TabIndex = 3;
            LevelEasy.Text = "Easy";
            LevelEasy.UseVisualStyleBackColor = true;
            LevelEasy.Click += LevelEasy_Click;
            // 
            // LevelMedium
            // 
            LevelMedium.Font = new Font("Stencil", 10F);
            LevelMedium.Location = new Point(371, 87);
            LevelMedium.Name = "LevelMedium";
            LevelMedium.Size = new Size(84, 83);
            LevelMedium.TabIndex = 4;
            LevelMedium.Text = "Medium";
            LevelMedium.UseVisualStyleBackColor = true;
            LevelMedium.Click += LevelMedium_Click;
            // 
            // LevelHard
            // 
            LevelHard.Font = new Font("Stencil", 10F);
            LevelHard.Location = new Point(487, 87);
            LevelHard.Name = "LevelHard";
            LevelHard.Size = new Size(84, 83);
            LevelHard.TabIndex = 5;
            LevelHard.Text = "Hard";
            LevelHard.UseVisualStyleBackColor = true;
            LevelHard.Click += LevelHard_Click;
            // 
            // ColorBlue
            // 
            ColorBlue.Font = new Font("Stencil", 10F);
            ColorBlue.Location = new Point(254, 202);
            ColorBlue.Name = "ColorBlue";
            ColorBlue.Size = new Size(84, 83);
            ColorBlue.TabIndex = 6;
            ColorBlue.Text = "Blue";
            ColorBlue.UseVisualStyleBackColor = true;
            ColorBlue.Click += ColorBlue_Click;
            // 
            // ColorWhite
            // 
            ColorWhite.Font = new Font("Stencil", 10F);
            ColorWhite.Location = new Point(371, 202);
            ColorWhite.Name = "ColorWhite";
            ColorWhite.Size = new Size(84, 83);
            ColorWhite.TabIndex = 7;
            ColorWhite.Text = "White";
            ColorWhite.UseVisualStyleBackColor = true;
            ColorWhite.Click += ColorWhite_Click;
            // 
            // ColorPink
            // 
            ColorPink.Font = new Font("Stencil", 10F);
            ColorPink.Location = new Point(487, 202);
            ColorPink.Name = "ColorPink";
            ColorPink.Size = new Size(84, 83);
            ColorPink.TabIndex = 8;
            ColorPink.Text = "Pink";
            ColorPink.UseVisualStyleBackColor = true;
            ColorPink.Click += ColorPink_Click;
            // 
            // StartGame
            // 
            StartGame.Font = new Font("Stencil", 20F);
            StartGame.Location = new Point(301, 323);
            StartGame.Name = "StartGame";
            StartGame.Size = new Size(234, 87);
            StartGame.TabIndex = 9;
            StartGame.Text = "Start Game";
            StartGame.UseVisualStyleBackColor = true;
            StartGame.Click += StartGame_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(800, 450);
            Controls.Add(StartGame);
            Controls.Add(ColorPink);
            Controls.Add(ColorWhite);
            Controls.Add(ColorBlue);
            Controls.Add(LevelHard);
            Controls.Add(LevelMedium);
            Controls.Add(LevelEasy);
            Controls.Add(NameColor);
            Controls.Add(NameLevel);
            Controls.Add(NameOfTheGame);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameOfTheGame;
        private Label NameLevel;
        private Label NameColor;
        private Button LevelEasy;
        private Button LevelMedium;
        private Button LevelHard;
        private Button ColorBlue;
        private Button ColorWhite;
        private Button ColorPink;
        private Button StartGame;
    }
}