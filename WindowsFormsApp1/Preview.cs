using System;
using System.Drawing;
using System.Windows.Forms;

namespace SelectRandomCharacter
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
        {

        }

        public void ChangeImage(Bitmap newImage) {
            pictureBox1.Image = newImage;
        }

        public void ChangeName(String newName) {
            label1.Text = newName;
        }

        public void ChangeWinStreak(int amount) {
            label_WinStreak.Text = "Win streak: " + amount;
        }

        private void Preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
