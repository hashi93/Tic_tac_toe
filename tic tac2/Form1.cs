using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac2
{
    public partial class Form1 : Form
    {
       // private bool turn;
        private int count;
        public Form1()
        {
            InitializeComponent();
            count = 0;
          //  turn = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (count <=9)
            {
                Button button = (Button)sender;
                player_move(button);
            }

           
            
        }

        private void player_move(Button button)
        {
          
                button.Text = "X";
                count++;
           

                AI_move();
                count++;
               // turn = true;
         
        }

        private void AI_move()
        {
            bool move = false;
           
            move=Search_for_win("O");
            if (move == false)
            {
                move = search_for_defeat("X");


                if (move==false)
                {
                    move = search_for_coner();

                    if (move==false)
                    {
                        move = search_for_free_cell();
                    }

                }
            }
            
           

        }

        private bool Search_for_win(string text)
        {
            
            //horizontal
            if (R1a.Text == text && R1b.Text ==text && R1c.Text == "")
                R1c.Text = text;
            else if (R1a.Text == "" && R1b.Text == text && R1c.Text == text)
                R1a.Text =text;
            else if (R1a.Text == text && R1b.Text == "" && R1c.Text == text)
                R1b.Text = text;

            else if (R2a.Text == text && R2b.Text == text && R2c.Text == "")
                R2c.Text =text;
            else if (R2a.Text == "" && R2b.Text ==text && R2c.Text == text)
                R2a.Text = text;
            else if (R2a.Text == text && R2b.Text == "" && R2c.Text ==text)
                R2b.Text = text;

            else if (R3a.Text ==text && R3b.Text == text && R3c.Text == "")
                R3c.Text = text;
            else if (R3a.Text == "" && R3b.Text ==text && R3c.Text == text)
                R3a.Text = text;
            else if (R3a.Text == text && R3b.Text == "" && R3c.Text == text)
                R3b.Text = text;


            //vertical

            else if (R1a.Text == text && R2a.Text == text && R3a.Text == "")
                R3a.Text = text;
            else if (R1a.Text == "" && R2a.Text ==text && R3a.Text == text)
                R1a.Text = text;
            else if (R1a.Text == text && R2a.Text == "" && R3a.Text == text)
                R2a.Text = text;

            else if (R1b.Text == text && R2b.Text == text && R3b.Text == "")
                R3b.Text = text;
            else if (R1b.Text == "" && R2b.Text == text && R3b.Text == text)
                R1b.Text = text;
            else if (R1b.Text == text && R2b.Text == "" && R3b.Text == text)
                R2b.Text = text;

            else if (R1c.Text == text && R2c.Text == text && R3c.Text == "")
                R3c.Text = text;
            else if (R1c.Text == "" && R2c.Text == text && R3c.Text == text)
                R1c.Text = text;
            else if (R1c.Text == text && R2c.Text == "" && R3c.Text == text)
                R2c.Text = text;

            //diagonal
            else if (R1a.Text == text && R2b.Text == text && R3c.Text == "")
                R3c.Text = text;
            else if (R1a.Text == "" && R2b.Text == text && R3c.Text == text)
                R1a.Text = text;
            else if (R1a.Text == text && R2b.Text == "" && R3c.Text == text)
                R2b.Text = text;

            else if (R1c.Text == text && R2b.Text == text && R3a.Text == "")
                R3a.Text = text;
            else if (R1c.Text == "" && R2b.Text == text && R3a.Text == text)
                R1c.Text = text;
            else if (R1c.Text == text && R2b.Text == "" && R3a.Text == text)
                R2b.Text = text;

            else
                return false;



            return true;

           

        }

        private bool search_for_coner()  
        {
            if (R1a.Text == "") { R1a.Text="O"; return true;}
            else if(R1c.Text==""){R1c.Text="O"; return true;}
            else if (R3a.Text == "") { R3a.Text = "O"; return true; }
            else if (R3c.Text == "") { R3c.Text = "O"; return true; }
            return false;
        }

        private bool search_for_defeat(string text)
        {
            //horizontal
            if (R1a.Text == text && R1b.Text == text && R1c.Text == "")
                R1c.Text = "O";
            else if (R1a.Text == "" && R1b.Text == text && R1c.Text == text)
                R1a.Text = "O";
            else if (R1a.Text == text && R1b.Text == "" && R1c.Text == text)
                R1b.Text = "O";

            else if (R2a.Text == text && R2b.Text == text && R2c.Text == "")
                R2c.Text = "O";
            else if (R2a.Text == "" && R2b.Text == text && R2c.Text == text)
                R2a.Text = "O";
            else if (R2a.Text == text && R2b.Text == "" && R2c.Text == text)
                R2b.Text = "O";

            else if (R3a.Text == text && R3b.Text == text && R3c.Text == "")
                R3c.Text = "O";
            else if (R3a.Text == "" && R3b.Text == text && R3c.Text == text)
                R3a.Text = "O";
            else if (R3a.Text == text && R3b.Text == "" && R3c.Text == text)
                R3b.Text = "O";


            //vertical

            else if (R1a.Text == text && R2a.Text == text && R3a.Text == "")
                R3a.Text = "O";
            else if (R1a.Text == "" && R2a.Text == text && R3a.Text == text)
                R1a.Text = "O";
            else if (R1a.Text == text && R2a.Text == "" && R3a.Text == text)
                R2a.Text = "O";

            else if (R1b.Text == text && R2b.Text == text && R3b.Text == "")
                R3b.Text = "O";
            else if (R1b.Text == "" && R2b.Text == text && R3b.Text == text)
                R1b.Text = "O";
            else if (R1b.Text == text && R2b.Text == "" && R3b.Text == text)
                R2b.Text = "O";

            else if (R1c.Text == text && R2c.Text == text && R3c.Text == "")
                R3c.Text = "O";
            else if (R1c.Text == "" && R2c.Text == text && R3c.Text == text)
                R1c.Text = "O";
            else if (R1c.Text == text && R2c.Text == "" && R3c.Text == text)
                R2c.Text ="O";

            //diagonal
            else if (R1a.Text == text && R2b.Text == text && R3c.Text == "")
                R3c.Text = "O";
            else if (R1a.Text == "" && R2b.Text == text && R3c.Text == text)
                R1a.Text = "O";
            else if (R1a.Text == text && R2b.Text == "" && R3c.Text == text)
                R2b.Text = "O";

            else if (R1c.Text == text && R2b.Text == text && R3a.Text == "")
                R3a.Text = "O";
            else if (R1c.Text == "" && R2b.Text == text && R3a.Text == text)
                R1c.Text = "O";
            else if (R1c.Text == text && R2b.Text == "" && R3a.Text == text)
                R2b.Text = "O";

            else
                return false;



            return true; 
        }

        private bool search_for_free_cell()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                    {
                        b.Text = "O";
                        return true;
                    }
                }
                return false;
            }


            return true;
        }

    
       

       
    }
}
