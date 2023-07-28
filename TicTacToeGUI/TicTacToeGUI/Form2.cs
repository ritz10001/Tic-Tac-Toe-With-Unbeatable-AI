using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public partial class Form2 : Form

    {




        public Form2()
        {
            InitializeComponent();



        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void DialogBoxError()
        {
            DialogResult r = MessageBox.Show("PLEASE ENTER A VALID POSITION NUMBER (0-8)", "Error", MessageBoxButtons.OK);
        }


        private void restart_button_Click_1(object sender, EventArgs e)
        {
            /*
            List<Label> boxes = new List<Label>() { label1, label2, label3, label4, label5, label6, label7, label8, label9 };

            foreach (Label l in boxes)
            {
                l.Text = " ";
            }
            */
        }

        public void arraychange(int index,string xo)
        {
            TicTacToeinterface.board[index] = xo;
            if (index == 0)
            {
                button1.Text = xo;
            }
            else if (index == 1)
            {
                button2.Text = xo;
            }
            else if (index == 2)
            {
                button3.Text = xo;
            }
            else if (index == 3)
            {
                button4.Text = xo;
            }
            else if (index == 4)
            {
                button5.Text = xo;
            }
            else if (index == 5)
            {
                button6.Text = xo;
            }
            else if (index == 6)
            {
                button7.Text = xo;
            }
            else if (index == 7)
            {
                button8.Text = xo;
            }
            else if (index == 8)
            {
                button9.Text = xo;
            }
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            if (TicTacToeinterface.freespace(TicTacToeinterface.board, 0))
            {

                arraychange(0, TicTacToeinterface.letter);
                TicTacToeinterface.computerinputletter();
            }
            else
            {
                DialogBoxError();
            }
        }

        private void restart_button_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            if (TicTacToeinterface.freespace(TicTacToeinterface.board, 1))
            {
                arraychange(0, TicTacToeinterface.letter);
                TicTacToeinterface.computerinputletter();
                
            }
            else
            {
                DialogBoxError();
            }
        }

        public void button3_Click_1(object sender, EventArgs e)
        {
            if (TicTacToeinterface.freespace(TicTacToeinterface.board, 2))
            {
                arraychange(0, TicTacToeinterface.letter);
                TicTacToeinterface.computerinputletter();
            }
            else
            {
                DialogBoxError();
            }
        }

        public void button4_Click_1(object sender, EventArgs e)
        {
            if (TicTacToeinterface.freespace(TicTacToeinterface.board, 3))
            {
                arraychange(0, TicTacToeinterface.letter);
                TicTacToeinterface.computerinputletter();
            }
            else
            {
                DialogBoxError();
            }
        }

        public void button5_Click_1(object sender, EventArgs e)
        {
            if (TicTacToeinterface.freespace(TicTacToeinterface.board, 4))
            {
                arraychange(0, TicTacToeinterface.letter);
                TicTacToeinterface.computerinputletter();
            }
            else
            {
                DialogBoxError();
            }
        }

        public void button6_Click_1(object sender, EventArgs e)
        {
            if (TicTacToeinterface.freespace(TicTacToeinterface.board, 5))
            {
                arraychange(0, TicTacToeinterface.letter);
                TicTacToeinterface.computerinputletter();
            }
            else
            {
                DialogBoxError();
            }
        }

        public void button7_Click_1(object sender, EventArgs e)
        {
            if (TicTacToeinterface.freespace(TicTacToeinterface.board, 6))
            {
                arraychange(0, TicTacToeinterface.letter);
                TicTacToeinterface.computerinputletter();
            }
            else
            {
                DialogBoxError();
            }
        }

        public void button8_Click_1(object sender, EventArgs e)
        {
            if (TicTacToeinterface.freespace(TicTacToeinterface.board, 7))
            {
                arraychange(0, TicTacToeinterface.letter);
                TicTacToeinterface.computerinputletter();
            }
            else
            {
                DialogBoxError();
            }
        }

        public void button9_Click_1(object sender, EventArgs e)
        {
            if (TicTacToeinterface.freespace(TicTacToeinterface.board, 8))
            {
                arraychange(0, TicTacToeinterface.letter);
                TicTacToeinterface.computerinputletter();
            }
            else
            {
                DialogBoxError();
            }
        }
    }
}
