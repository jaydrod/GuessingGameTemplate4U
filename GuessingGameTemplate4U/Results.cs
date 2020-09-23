using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
    /* 
     * Jayden Roddick 
     * Guessing Game 
     * 09/23/20
     */
{
    public partial class Results : UserControl
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.guesses.Count(); i++)
            {
               results2lable.Text +=  Form1.guesses[i] + " ";
            }

            Form1.guesses.Sort();

            for (int i = 0; i < Form1.guesses.Count(); i++)
            {
                label3results.Text += Form1.guesses[i] + " ";
            }
        }
    }
}