namespace TicTacToeGUI
{
    public partial class Form1 : Form
    {
        TicTacToeinterface t = new TicTacToeinterface();
        public Form1()
        {
            InitializeComponent();
        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}