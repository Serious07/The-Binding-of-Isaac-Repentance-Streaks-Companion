using System;
using System.Windows.Forms;

namespace SelectRandomCharacter
{
    public partial class Settings : Form
    {
        private Main main;

        public Settings(Main main)
        {
            InitializeComponent();

            this.main = main;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        public GroupBox getCharactersGroupBox()
        {
            return groupBox1;
        }

        private void button_Isaac_Click(object sender, EventArgs e)
        {
            main.SetCharacter(0);
        }

        private void button_Magdalene_Click(object sender, EventArgs e)
        {
            main.SetCharacter(1);
        }

        private void button_Cain_Click(object sender, EventArgs e)
        {
            main.SetCharacter(2);
        }

        private void button_Judas_Click(object sender, EventArgs e)
        {
            main.SetCharacter(3);
        }

        private void button_Blue_baby_Click(object sender, EventArgs e)
        {
            main.SetCharacter(4);
        }

        private void button_Eve_Click(object sender, EventArgs e)
        {
            main.SetCharacter(5);
        }

        private void button_Samson_Click(object sender, EventArgs e)
        {
            main.SetCharacter(6);
        }

        private void button_Azazel_Click(object sender, EventArgs e)
        {
            main.SetCharacter(7);
        }

        private void button_Lazarus_Click(object sender, EventArgs e)
        {
            main.SetCharacter(8);
        }

        private void button_Eden_Click(object sender, EventArgs e)
        {
            main.SetCharacter(9);
        }

        private void button_Lost_Click(object sender, EventArgs e)
        {
            main.SetCharacter(10);
        }

        private void button_Lilith_Click(object sender, EventArgs e)
        {
            main.SetCharacter(11);
        }

        private void button_Keeper_Click(object sender, EventArgs e)
        {
            main.SetCharacter(12);
        }

        private void button_Apollyon_Click(object sender, EventArgs e)
        {
            main.SetCharacter(13);
        }

        private void button_Bethany_Click(object sender, EventArgs e)
        {
            main.SetCharacter(14);
        }

        private void button_Jacob_Click(object sender, EventArgs e)
        {
            main.SetCharacter(15);
        }

        private void button_Tainted_Isaac_Click(object sender, EventArgs e)
        {
            main.SetCharacter(16);
        }

        private void button_Tainted_Magdalene_Click(object sender, EventArgs e)
        {
            main.SetCharacter(17);
        }

        private void button_Tainted_Cain_Click(object sender, EventArgs e)
        {
            main.SetCharacter(18);
        }

        private void button_Tainted_Judas_Click(object sender, EventArgs e)
        {
            main.SetCharacter(19);
        }

        private void button_Tainted_Blue_baby_Click(object sender, EventArgs e)
        {
            main.SetCharacter(20);
        }

        private void button_Tainted_Eve_Click(object sender, EventArgs e)
        {
            main.SetCharacter(21);
        }

        private void button_Tainted_Samson_Click(object sender, EventArgs e)
        {
            main.SetCharacter(22);
        }

        private void button_Tainted_Azazel_Click(object sender, EventArgs e)
        {
            main.SetCharacter(23);
        }

        private void button_Tainted_Lazarus_Click(object sender, EventArgs e)
        {
            main.SetCharacter(24);
        }

        private void button_Tainted_Eden_Click(object sender, EventArgs e)
        {
            main.SetCharacter(25);
        }

        private void button_Tainted_Lost_Click(object sender, EventArgs e)
        {
            main.SetCharacter(26);
        }

        private void button_Tainted_Lilith_Click(object sender, EventArgs e)
        {
            main.SetCharacter(27);
        }

        private void button_Tainted_Keeper_Click(object sender, EventArgs e)
        {
            main.SetCharacter(28);
        }

        private void button_Tainted_Apollyon_Click(object sender, EventArgs e)
        {
            main.SetCharacter(29);
        }

        private void button_Tainted_Bethany_Click(object sender, EventArgs e)
        {
            main.SetCharacter(30);
        }

        private void button_Tainted_Jacob_Click(object sender, EventArgs e)
        {
            main.SetCharacter(31);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            main.SetCurrentWinStreak((int)numericUpDown1.Value);
        }

        public void SetNumericUpDown1Value(int value) {
            numericUpDown1.Value = value;
        }
    }
}
