using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGUI
{
    public class TicTacToeinterface
    {
        
        
 

        public static string letter = "";
        public static bool finished = false;
        public static int chance = 0;

        public static string win = "";

        public static string winperson = "";
        public static string completter = "";

        public static int counter = 0;

        public static string[] board = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public static string invalid = "''/`~+-''\';:'?|{}<>.,[]()@!#$%^&*-_=qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";

        public static bool freespace(string[] board, int position)
        {
            if (board[position] == "X" || board[position] == "O")
            {
                return false;

            }
            return true;
        }

        public static void computerinputletter()
        {
            Form2 f2 = new Form2();
            Random random = new Random();
            int randomnum = random.Next(0, 9);
            if (freespace(board, randomnum) && finishspace(board)==false)
            {
                f2.arraychange(randomnum, "O");
            }
            else if(finishspace(board)==true)
            {
                chance++;
                winner(board);
            }
            chance++;
            winner(board);


        }

        static void winner(string[] board)
        {


            if (string.Compare(board[0], board[1]) == 0 && string.Compare(board[1], board[2]) == 0 && (board[0] == "X" || board[0] == "O"))
            {
                win = board[0];
            }

            /*3,4,4,5*/
            else if (string.Compare(board[3], board[4]) == 0 && string.Compare(board[4], board[5]) == 0 && (board[3] == "X" || board[3] == "O"))
            {
                win = board[3];
            }
            /*6,7,7,8*/
            else if (string.Compare(board[6], board[7]) == 0 && string.Compare(board[7], board[8]) == 0 && (board[6] == "X" || board[6] == "O"))
            {
                win = board[6];
            }
            /*0,3,3,6*/
            else if (string.Compare(board[0], board[3]) == 0 && string.Compare(board[3], board[6]) == 0 && (board[0] == "X" || board[0] == "O"))
            {
                win = board[0];
            }
            /*1,4,4,7*/
            else if (string.Compare(board[1], board[4]) == 0 && string.Compare(board[4], board[7]) == 0 && (board[1] == "X" || board[1] == "O"))
            {
                win = board[1];
            }
            /*2,5,5,8*/
            else if (string.Compare(board[2], board[5]) == 0 && string.Compare(board[5], board[8]) == 0 && (board[2] == "X" || board[2] == "O"))
            {
                win = board[2];
            }
            /*0,4,4,8*/
            else if (board[0] == board[4] && board[4] == board[8] && (board[0] == "X" || board[0] == "O"))
            {
                win = board[0];
            }
            /*2,4,4,6*/
            else if (string.Compare(board[2], board[4]) == 0 && string.Compare(board[4], board[6]) == 0 && (board[2] == "X" || board[2] == "O"))
            {
                win = board[2];
            }

            if (win == "" && finishspace(board) == true)
            {
                finished = true;
                DialogResult r = MessageBox.Show("ITS A DRAW MATCH!", "GAME OVER", MessageBoxButtons.OK);
                


            }
            else if (win == "" && !(finishspace(board)))
            {

            }


            else if (win == "X")
            {
                finished = true;
                Console.WriteLine();
                winperson = "X";



            }
            else
            {
                finished = true;
                Console.WriteLine();
                winperson = "O";

            }
            wincheck();

        }

        static bool finishspace(string[] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == "X" || board[i] == "O")
                {
                    counter++;
                    continue;
                }
                else
                {
                    return false;
                }

            }
            if (counter == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void wincheck()
        {
            if (finished)
            {
                if (winperson == "X")
                {   
                    DialogResult r = MessageBox.Show("X IS THE WINNER", "GAME OVER", MessageBoxButtons.OK);
                    
                }
                else if (winperson == "O")
                {
                    DialogResult r = MessageBox.Show("O IS THE WINNER", "GAME OVER", MessageBoxButtons.OK);
                }
                Console.WriteLine();
                Console.WriteLine("THANKS FOR PLAYING!");
                /*endfunction();*/
                /*resetboard(board);*/
            }
            else
            {
                if (chance % 2 == 0)
                {

                    /*inputletter();*/
                }
                else
                {
                    computerinputletter();
                }
            }



        }





    }
}
