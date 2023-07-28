using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TicTacToeinterface.letter = "X";
            TicTacToeinterface.completter = "O";
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TicTacToeinterface.letter = "O";
            TicTacToeinterface.completter = "X";
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
