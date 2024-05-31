using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pac_man_2part_
{
    public partial class Form2 : Form
    {
        public int Level { get; private set; } = -1; // Используем -1 как значение по умолчанию, чтобы указать, что уровень не выбран
        public string Color { get; private set; } = null; // Значение по умолчанию для цвета

        public Form2()
        {
            InitializeComponent();
        }

        private void LevelEasy_Click(object sender, EventArgs e)
        {
            LevelEasy.BackColor = System.Drawing.Color.BlueViolet;
            Level = 1;

        }

        private void LevelMedium_Click(object sender, EventArgs e)
        {
            LevelMedium.BackColor = System.Drawing.Color.BlueViolet;
            Level = 2;

        }

        private void LevelHard_Click(object sender, EventArgs e)
        {
            LevelHard.BackColor = System.Drawing.Color.BlueViolet;
            Level = 3;

        }

        private void ColorBlue_Click(object sender, EventArgs e)
        {
            ColorBlue.BackColor = System.Drawing.Color.BlueViolet;
            Color = "Blue";

        }

        private void ColorWhite_Click(object sender, EventArgs e)
        {
            ColorWhite.BackColor = System.Drawing.Color.BlueViolet;
            Color = "White";

        }

        private void ColorPink_Click(object sender, EventArgs e)
        {
            ColorPink.BackColor = System.Drawing.Color.BlueViolet;
            Color = "Pink";

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            if (Level != -1 && Color != null)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select both level and color before confirming.");
            }
        }
    }
}
