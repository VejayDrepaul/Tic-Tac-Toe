using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> options = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9
        };

        int[] nums = { 1, 2, 3,4, 5, 6,7, 8, 9 };

        void enabled_false()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void computer_guess()
        {
            Random random = new Random();
            int test = random.Next(options.Count);  

            if (test == 1 && button1.Text == "")
            {
                button1.Text = "O";
                button1.Enabled = false;
            }

            if (test == 2 && button2.Text == "")
            {
                button2.Text = "O";
                button2.Enabled = false;
            }

            if (test == 3 && button3.Text == "")
            {
                button3.Text = "O";
                button3.Enabled = false;
            }

            if (test == 4 && button4.Text == "")
            {
                button4.Text = "O";
                button4.Enabled = false;
            }

            if (test == 5 && button5.Text == "")
            {
                button5.Text = "O";
                button5.Text = "O";
            }

            if (test == 6 && button6.Text == "")
            {
                button6.Text = "O";
                button6.Text = "O";
            }

            if (test == 7 && button7.Text == "")
            {
                button7.Text = "O";
                button7.Text = "O";
            }

            if (test == 8 && button8.Text == "")
            {
                button8.Text = "O";
                button8.Text = "O";
            }

            if (test == 9 && button9.Text == "")
            {
                button9.Text = "O";
                button9.Text = "O";
            }

            options.Remove(test);
        }

        void button_logic(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == "")
            {
                button.Text = "X";
                button.Enabled = false;
                computer_guess();
                score();
            }
            else if (button.Text == "O")
            {
                MessageBox.Show("This spot is taken!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            options.Clear();
            options.AddRange(nums);

            button1.Text = "";
            button1.BackColor = Color.Transparent;

            button2.Text = "";
            button2.BackColor = Color.Transparent;

            button3.Text = "";
            button3.BackColor = Color.Transparent;

            button4.Text = "";
            button4.BackColor = Color.Transparent;

            button5.Text = "";
            button5.BackColor = Color.Transparent;

            button6.Text = "";
            button6.BackColor = Color.Transparent;

            button7.Text = "";
            button7.BackColor = Color.Transparent;

            button8.Text = "";
            button8.BackColor = Color.Transparent;

            button9.Text = "";
            button9.BackColor = Color.Transparent;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        void score()
        {
            // Horizontal Wins
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enabled_false();
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enabled_false();
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enabled_false();
            }

            // Vertical Wins
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Diagonal Wins
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Horizontal Wins
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enabled_false();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enabled_false();
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enabled_false();
            }

            // Vertical Wins
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Diagonal Wins
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                MessageBox.Show("You Won!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
