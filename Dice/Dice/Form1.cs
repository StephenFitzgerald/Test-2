using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice
{
    public partial class Form1 : Form
    {
        //Here I am defining the variables for my project
        Image[] diceImages;
        int[] dice;
        Random rand;

                public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diceImages = new Image[6];
            diceImages[0] = Properties.Resources.Die_1;
            diceImages[1] = Properties.Resources.Die_2;
            diceImages[2] = Properties.Resources.Die_3;
            diceImages[3] = Properties.Resources.Die_4;
            diceImages[4] = Properties.Resources.Die_5;
            diceImages[5] = Properties.Resources.Die_6;

            dice = new int[2] { 0, 0 };

            rand = new Random();

        }

       

        #region Private Methods
    
        private void btn_rolldice_Click(object sender, EventArgs e)
        {
           RollDice();
        }

        private void RollDice()
        {
            for (int i = 0; i < dice.Length; i++)
                dice[i] = rand.Next(1, 6);

            lbl_die_1.Image = diceImages[dice[0]];
            lbl_die_2.Image = diceImages[dice[1]];


        }
        #endregion


    }
}


