using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuicadeGame
{
    public partial class Wisielec : Form
    {
        public Wisielec()
        {
            InitializeComponent();

        }

        private void Wisielec_Load(object sender, EventArgs e) {
            ResetGame();

        }

        private void Clicked(object sender, EventArgs e) {
            String letterStr = ((Button)sender).Text;
            char letter = letterStr.ToArray()[0];
            StringBuilder stringBuilder = new StringBuilder(Password.Text);

            if (password.IndexOf(letter) != -1) {
                if (Password.Text.IndexOf(letter) == -1) {
                    int index = 0;
                    foreach (char character in password) {
                        if (character == letter) {
                            stringBuilder[index] = letter;

                        }
                        ++index;

                    }
                    Password.Text = stringBuilder.ToString();
                    if (Password.Text.IndexOf("_") == -1) {
                        MessageBox.Show("YOU WON!");
                        ResetGame();

                    }


                }
                else {
                    HandleMistake();

                }

            }
            else {
                HandleMistake();

            }

        }
        private void HandleMistake()
        {
            ++IndexBox;
            if (IndexBox == 10)
            {
                MessageBox.Show("YOU'RE DEAD!");
                ResetGame();
                return;

            }
            SuicadeBox.ImageLocation = ".\\assets\\" + IndexBox + ".jpg";

        }
        private void ResetGame() {
            IndexBox = 0;
            SuicadeBox.ImageLocation = ".\\assets\\" + IndexBox + ".jpg";
            password = Calculations.RandomPassword();
            Password.Text = Calculations.HashPassword(password);


        }

    }

}
