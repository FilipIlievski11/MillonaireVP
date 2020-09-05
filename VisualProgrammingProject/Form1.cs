using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualProgrammingProject.Model;

namespace VisualProgrammingProject
{
    public partial class Form1 : Form
    {
        public Sounds sounds;
        public string PlayerName { get; set; }
        public Form1()
        {
            InitializeComponent();
            sounds = new Sounds();
            sounds.playIntro();
        }

        private void PlayBttn_Click(object sender, EventArgs e)
        {
            if(inputName.Text.Length == 0)
            {
                nameRequiredError.Visible = true;
            }
            else {
                nameRequiredError.Visible = false;
                PlayerName = inputName.Text;
                this.Hide();
                Form2 game = new Form2(this);
                game.Show();
            }
        }

        private void InputName_TextChanged(object sender, EventArgs e)
        {
            nameRequiredError.Visible = false;
        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HighScoresBttn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            this.Hide();
            form3.Show();
        }
    }
}
