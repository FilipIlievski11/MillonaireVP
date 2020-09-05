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
using VisualProgrammingProject.Helpers;
using VisualProgrammingProject.Model;

namespace VisualProgrammingProject
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        public HighScores highScores;
        public QuestionsQuestion currentQuestion;
        public Game Game;
        public Sounds sounds;
        public Form2(Form1 form1)
        {
            sounds = new Sounds();
            sounds.playLetsStart();
            this.Game = new Game();
            highScores = new HighScores();
            this.form1 = form1;
            InitializeComponent();
            getNewQuestion();
        }

        public void getNewQuestion()
        {
            currentQuestion = new QuestionsQuestion();
            currentQuestion = Game.getAQuestion();
            questionLabel.Text = currentQuestion.QuestionText;
            AnswerA.Text += currentQuestion.AnswerA;
            AnswerB.Text += currentQuestion.AnswerB;
            AnswerC.Text += currentQuestion.AnswerC;
            AnswerD.Text += currentQuestion.AnswerD;
        }

        private void pickAnswer(object sender, EventArgs e)
        {
            sounds.playFinalAnswer();
            string answer = (sender as Label).Text;
            string message = LabelTextConstants.Is + "'" + answer + "'" + LabelTextConstants.FinalAnswer;
            string title = LabelTextConstants.FinalDecision;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                var pickedAnswer = answer.Substring(0, 1);
                if (Game.checkAnswer(currentQuestion.RightAnswer, pickedAnswer))
                {
                    sounds.playCorrectAnswer();
                    (sender as Label).ForeColor = Color.Lime;
                    var cash = Game.getCurrentCash();
                    changeCashLabel.Text = cash.ToString() + LabelTextConstants.Dollar;
                    title = LabelTextConstants.Congratulation + LabelTextConstants.exclamationMark;
                    if (currentQuestion.Number != 15)
                    {
                        message = LabelTextConstants.YouWon + cash + LabelTextConstants.Dollar +
                                    LabelTextConstants.exclamationMark + "\n" + LabelTextConstants.NextQuestion;

                        result = MessageBox.Show(message, title, buttons);

                        if (result == DialogResult.Yes)
                        {
                            changeCashLabel.Text = cash.ToString() + LabelTextConstants.Dollar;
                            if (currentQuestion.Number != 15)
                            {
                                Game.rightAnswer();
                                ((PictureBox)Controls.Find("question" + currentQuestion.Number + "Picture", true)[0]).Visible = false;
                                ((PictureBox)Controls.Find("question" + Game.questionCounter + "Picture", true)[0]).Visible = true;
                                clearQuestion();
                                getNewQuestion();
                                sounds.playLetsStart();
                            }
                        }
                        else
                        {
                            title = LabelTextConstants.YouGaveUp;
                            message = LabelTextConstants.YouWon + cash + LabelTextConstants.Dollar + LabelTextConstants.exclamationMark;
                            buttons = MessageBoxButtons.OK;
                            MessageBox.Show(message, title, buttons);
                            highScores.saveScore(form1.PlayerName, cash);
                            form1.Show();
                            this.Hide();
                            this.Dispose();
                        }
                    }
                    else
                    {
                        message = LabelTextConstants.YouWon + cash + LabelTextConstants.Dollar +
                                LabelTextConstants.exclamationMark + "\n" + LabelTextConstants.Millionaire;
                        buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, title, buttons);
                        highScores.saveScore(form1.PlayerName, cash);
                        form1.Show();
                        this.Hide();
                        this.Dispose();
                        sounds.playIntro();
                    }
                }
                else
                {
                    sounds.playWrongAnswer();
                    (sender as Label).ForeColor = Color.Red;
                    ((Label)Controls.Find("Answer" + currentQuestion.RightAnswer, true)[0]).ForeColor = Color.Lime;
                    var cash = Game.playerGetsHowMuchCash(false);
                    changeCashLabel.Text = cash.ToString() + LabelTextConstants.Dollar;
                    title = LabelTextConstants.WrongAnswer;
                    message = LabelTextConstants.YouWon + cash + LabelTextConstants.Dollar + LabelTextConstants.exclamationMark;
                    buttons = MessageBoxButtons.OK;
                    highScores.saveScore(form1.PlayerName, cash);
                    MessageBox.Show(message, title, buttons);
                    form1.Show();
                    this.Hide();
                    this.Dispose();
                    sounds.playIntro();
                }
            }

        }

        private void clearQuestion()
        {
            audienceLabelGroup.Visible = false;
            friendHelpGroup.Visible = false;
            MillionaireLogo.Visible = true;


            questionLabel.Text = String.Empty;

            AnswerA.Text = "A:";
            AnswerA.Visible = true;
            AnswerA.ForeColor = Color.CornflowerBlue;

            AnswerB.Text = "B:";
            AnswerB.Visible = true;
            AnswerB.ForeColor = Color.CornflowerBlue;


            AnswerC.Text = "C:";
            AnswerC.Visible = true;
            AnswerC.ForeColor = Color.CornflowerBlue;

            AnswerD.Text = "D:";
            AnswerD.Visible = true;
            AnswerD.ForeColor = Color.CornflowerBlue;
        }

        private void GiveUpBttn_Click(object sender, EventArgs e)
        {
            var cash = Game.playerGetsHowMuchCash(true);
            string title = LabelTextConstants.YouGaveUp;
            string message = LabelTextConstants.YouWon + cash + LabelTextConstants.Dollar + LabelTextConstants.exclamationMark;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons);
            highScores.saveScore(form1.PlayerName, cash);
            form1.Show();
            this.Hide();
            this.Dispose();
            sounds.playIntro();
        }

        private void HalfHelpNotUsedPicture_Click(object sender, EventArgs e)
        {
            halfHelpNotUsedPicture.Visible = false;
            halfHelpUsedPicture.Visible = true;

            var AnswersToBeExcluded = Game.useHalfHalfHelp(currentQuestion.RightAnswer);
            foreach(var answer in AnswersToBeExcluded)
                ((Label)Controls.Find("Answer" + answer, true)[0]).Visible = false;
        }

        private void AudienceHelpNotUsedPicture_Click(object sender, EventArgs e)
        {
            friendHelpGroup.Visible = false;
            audienceHelpNotUsedPicture.Visible = false;
            audienceHelpUsedPicture.Visible = true;
            var answersPercetages = Game.useAskAudienceHelp(currentQuestion.RightAnswer);
            audVoteA.Text = "A:" + answersPercetages[0] + "%";
            audVoteB.Text = "B:" + answersPercetages[1] + "%";
            audVoteC.Text = "C:" + answersPercetages[2] + "%";
            audVoteD.Text = "D:" + answersPercetages[3] + "%";
            audienceLabelGroup.Visible = true;
            MillionaireLogo.Visible = false;

        }

        private void FriendHelpNotUsedPicture_Click(object sender, EventArgs e)
        {
            MillionaireLogo.Visible = false;
            audienceLabelGroup.Visible = false;
            friendHelpNotUsedPicture.Visible = false;
            friendHelpUsedPicture.Visible = true;
            var yourFriendSaid = Game.userAskFriendHelp(currentQuestion.RightAnswer);
            friendHelpGroup.Visible = true;
            askFriendHelpLabel.Text = yourFriendSaid;
        }

    }
}
