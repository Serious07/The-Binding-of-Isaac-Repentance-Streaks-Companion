using System;
using System.Drawing;
using System.Windows.Forms;

namespace SelectRandomCharacter
{
    public partial class Main : Form
    {
        public Character[] chars = {
            new Character(Properties.Resources.Isaac, "Isaac"),
            new Character(Properties.Resources.Magdalene, "Magdalene"),
            new Character(Properties.Resources.Cain, "Cain"),
            new Character(Properties.Resources.Judas, "Judas"),
            new Character(Properties.Resources.Blue_Baby, "Blue baby"),
            new Character(Properties.Resources.Eve, "Eve"),
            new Character(Properties.Resources.Samson, "Samson"),
            new Character(Properties.Resources.Azazel, "Azazel"),
            new Character(Properties.Resources.Lazarus, "Lazarus"),
            new Character(Properties.Resources.Eden, "Eden"),
            new Character(Properties.Resources.Lost, "Lost"),
            new Character(Properties.Resources.Lilith, "Lilith"),
            new Character(Properties.Resources.Keeper, "Keeper"),
            new Character(Properties.Resources.Apollyon, "Apollyon"),
            new Character(Properties.Resources.Bethany, "Bethany"),
            new Character(Properties.Resources.Jacob, "Jacob"),
            new Character(Properties.Resources.Tainted_Isaac, "T. Isaac"),
            new Character(Properties.Resources.Tainted_Magdalene, "T. Magdalene"),
            new Character(Properties.Resources.Tainted_Cain, "T. Cain"),
            new Character(Properties.Resources.Tainted_Judas, "T. Judas"),
            new Character(Properties.Resources.Tainted_Blue_Baby, "T. Blue baby"),
            new Character(Properties.Resources.Tainted_Eve, "T. Eve"),
            new Character(Properties.Resources.Tainted_Samson, "T. Samson"),
            new Character(Properties.Resources.Tainted_Azazel, "T. Azazel"),
            new Character(Properties.Resources.Tainted_Lazarus, "T. Lazarus"),
            new Character(Properties.Resources.Tainted_Eden, "T. Eden"),
            new Character(Properties.Resources.Tainted_Lost, "T. Lost"),
            new Character(Properties.Resources.Tainted_Lilith, "T. Lilith"),
            new Character(Properties.Resources.Tainted_Keeper, "T. Keeper"),
            new Character(Properties.Resources.Tainted_Apollyon, "T. Apollyon"),
            new Character(Properties.Resources.Tainted_Bethany, "T. Bethany"),
            new Character(Properties.Resources.Tainted_Jacob, "T. Jacob"),
        };

        private Preview previewWindow;
        private Settings settings;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            previewWindow = new Preview();
            previewWindow.Show();
            previewWindow.SetDesktopLocation(Properties.Settings.Default.PreviewWindowPos.Width, Properties.Settings.Default.PreviewWindowPos.Height);
            previewWindow.ChangeWinStreak(Properties.Settings.Default.CurrentWinStreak);

            settings = new Settings(this);
            settings.SetNumericUpDown1Value(Properties.Settings.Default.CurrentWinStreak);
            settings.Hide();

            SetDesktopLocation(Properties.Settings.Default.MainWindowPos.Width, Properties.Settings.Default.MainWindowPos.Height);

            SetCharacter(Properties.Settings.Default.LastChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SelectRandomCharacterAndUpdatePreview() {
            Character rndChar = SelectRandomCharacter();

            previewWindow.ChangeImage(rndChar.image);
            previewWindow.ChangeName(rndChar.name);
        }

        public void SetCharacter(int index)
        {
            previewWindow.ChangeImage(chars[index].image);
            previewWindow.ChangeName(chars[index].name);

            settings.getCharactersGroupBox().Text = "Current: " + chars[index].name;

            Properties.Settings.Default.LastChar = index;
            Properties.Settings.Default.Save();
        }

        public void SetCurrentWinStreak(int value) {
            Properties.Settings.Default.CurrentWinStreak = value;
            Properties.Settings.Default.Save();

            previewWindow.ChangeWinStreak(Properties.Settings.Default.CurrentWinStreak);
        }

        private Character SelectRandomCharacter() {
            Random rnd = new Random();

            Properties.Settings.Default.LastChar = rnd.Next(0, chars.Length);
            Properties.Settings.Default.Save();

            return chars[Properties.Settings.Default.LastChar];
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MainWindowPos = new Size(this.Location.X, this.Location.Y);
            Properties.Settings.Default.PreviewWindowPos = new Size(previewWindow.Location.X, previewWindow.Location.Y);
            Properties.Settings.Default.Save();
        }

        private void button_Win_Click(object sender, EventArgs e)
        {
            UpCurrentWinStreak();

            SelectRandomCharacterAndUpdatePreview();
        }

        private void button_Lose_Click(object sender, EventArgs e)
        {
            ResetCurrentWinStreak();

            SelectRandomCharacterAndUpdatePreview();
        }

        private void UpCurrentWinStreak() {
            Properties.Settings.Default.CurrentWinStreak += 1;
            Properties.Settings.Default.Save();

            settings.SetNumericUpDown1Value(Properties.Settings.Default.CurrentWinStreak);
            previewWindow.ChangeWinStreak(Properties.Settings.Default.CurrentWinStreak);
        }

        private void ResetCurrentWinStreak() {
            Properties.Settings.Default.CurrentWinStreak = 0;
            Properties.Settings.Default.Save();

            settings.SetNumericUpDown1Value(Properties.Settings.Default.CurrentWinStreak);
            previewWindow.ChangeWinStreak(Properties.Settings.Default.CurrentWinStreak);
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            if (settings.Visible == false)
            {
                settings.Show();
            } else {
                settings.Hide();
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
