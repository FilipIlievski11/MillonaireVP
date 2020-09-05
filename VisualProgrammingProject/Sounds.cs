using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingProject
{
    public class Sounds
    {
        private SoundPlayer IntroMusic;
        private SoundPlayer NewGame;
        private SoundPlayer WrongAnswer;
        private SoundPlayer FinalAnswer;
        private SoundPlayer CorrectAnswer;


        public Sounds()
        {
            NewGame = new SoundPlayer(Properties.Resources.lets_play);
            IntroMusic = new SoundPlayer(Properties.Resources.main_theme);
            WrongAnswer = new SoundPlayer(Properties.Resources.wrong_answer);
            FinalAnswer = new SoundPlayer(Properties.Resources.final_answer);
            CorrectAnswer = new SoundPlayer(Properties.Resources.correct_answer);
        }

        public void playIntro()
        {
            IntroMusic.PlayLooping();
        }
        public void playLetsStart()
        {
            NewGame.Play();
        }
        public void playWrongAnswer()
        {
            WrongAnswer.Play();
        }

        public void playFinalAnswer()
        {
            FinalAnswer.Play();
        }

        public void playCorrectAnswer()
        {
            CorrectAnswer.Play();
        }
    }
}
