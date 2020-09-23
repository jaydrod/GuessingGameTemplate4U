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
{
    public partial class Results : UserControl
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <Form1.guesses.Count(); i++)

            {

               results2lable.Text += "\n" + i + ": " + (i);

            }
        }
    }
}
