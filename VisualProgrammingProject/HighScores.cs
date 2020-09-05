using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VisualProgrammingProject.Model;

namespace VisualProgrammingProject
{
    public class HighScores
    {
        public HighScoreScore[] highScores;

        public HighScores()
        {
            getHighScoresData();
        }


        public List<HighScoreScore> getTop5HighScores()
        {
            if (highScores != null && highScores.Length > 0)
                return highScores.OrderByDescending(x => x.Score).Take(5).ToList();
            else
                return new List<HighScoreScore>();
        }

        public void getHighScoresData()
        {
            string fileName = "highscores.xml";
            var CurrentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            highScores = Helpers.XMLHelper.ReadXml<HighScore>(Path.Combine(CurrentDirectory, fileName)).Score;
        }

        public void saveScore(string PlayerName, int Cash)
        {
            string fileName = "highscores.xml";
            var CurrentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var tempHighScorers = new HighScoreScore[highScores.Length + 1];
            for (int i = 0; i < tempHighScorers.Length; i++)
            {
                if (i + 1 < tempHighScorers.Length)
                {
                    tempHighScorers[i] = highScores[i];
                }
                else
                {
                    tempHighScorers[i] = new HighScoreScore();
                    tempHighScorers[i].Username = PlayerName;
                    tempHighScorers[i].Score = (uint)Cash;
                }
            }
            HighScore highScore = new HighScore() { Score = tempHighScorers };
            Helpers.XMLHelper.SaveXml<HighScore>(highScore, Path.Combine(CurrentDirectory, fileName));
        }
    }
}
