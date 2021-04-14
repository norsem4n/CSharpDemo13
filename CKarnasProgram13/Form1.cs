/* Program:         HW05 - Assignment 13
 * Developed by:    Christopher Karnas
 * Date Created:    November 2020
 * Last Modified:   11.03.20
 * Class Name:      Form1
 * Descrtiption:    Display wins and repeat NFL champions
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKarnasProgram13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWins_Click(object sender, EventArgs e)
        {
            //declare variables 
            string aTeam = cboxTeams.Text.ToString();
            int wins = 0;

            //display message box if team is unselected
            if (cboxTeams.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an NFL team from the first dropdown list", "Team Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //loop to count wins of selected team
            for (int x = 0; x < cboxChamps.Items.Count; ++x)
            {
                if (aTeam == cboxChamps.Items[x].ToString())
                {
                    ++wins;
                }
            }
            lblResult.Text = $"The {aTeam} has won the Superbowl {wins} time(s)";
        }

        private void btnBack2Back_Click(object sender, EventArgs e)
        {
            //declare variables 
            int backToBack = 0;

            //loop to count back to back wins
            for (int x = 0; x < cboxChamps.Items.Count - 1; ++x)
            {
                if (cboxChamps.Items[x].ToString() == cboxChamps.Items[x+1].ToString())
                {
                    ++backToBack;
                }
            }
            //display result
            lblResult.Text = $"Teams have won the Superbowl back to back {backToBack} time(s).";
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //declare variables
            DialogResult aDisplay;

            //display warning message
            aDisplay = MessageBox.Show("Do you wish to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //take desired action
            if (aDisplay == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                cboxTeams.Focus();
            }
        }
    }
}
