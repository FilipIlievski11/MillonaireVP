using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class Form3 : Form
    {
        public Form1 form1;
        public HighScores highScores;
        public Form3(Form1 form1)
        {
            this.form1 = form1;
            highScores = new HighScores();
            InitializeComponent();

            var highScorers = highScores.getTop5HighScores();

            for (int i = 1; i < 6; i++)
            {
                if (i <= highScorers.Count)
                {


                        var control = (Label)Controls.Find("playerNumber" + i, true)[0];
                        control.Visible = true;
                        control.Text = i + ". " + highScorers[i - 1].Username + " - " + highScorers[i - 1].Score + "$";


                }
                else
                {
                    ((Label)Controls.Find("playerNumber" + i, true)[0]).Visible = false;
                }


            }
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
            this.Dispose();
        }
    }
}
