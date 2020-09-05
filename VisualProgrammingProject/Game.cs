using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VisualProgrammingProject.Helpers;
using VisualProgrammingProject.Model;

namespace VisualProgrammingProject
{
    public class Game
    {
        public int questionCounter = 1;
        public QuestionsQuestion[] questions;
        public Game()
        {
            getQuestionData();
        }

        public QuestionsQuestion getAQuestion()
        {
            Random random = new Random();
            var tempList = questions.Where(x => x.Number == questionCounter).ToList();
            int randomIndex = random.Next(tempList.Count);
            return tempList[randomIndex];
        }

        public void rightAnswer()
        {
            questionCounter++;
        }

        public bool checkAnswer(string correctAnswer, string pickedAnswer)
        {
            if (correctAnswer.Equals(pickedAnswer))
                return true;
            else
                return false;
        }



        public int playerGetsHowMuchCash(bool gaveUp)
        {
            if (questionCounter == 1)
                return 0;
            if (gaveUp)
                return int.Parse(Enumerators.GetEnumDescription((Cash)(questionCounter - 1)));
            else
            {
                if (questionCounter - 1 < 5)
                    return 0;
                else if (questionCounter - 1 >= 5 && questionCounter - 1 < 10)
                    return int.Parse(Enumerators.GetEnumDescription(Cash.Answer5));
                else
                    return int.Parse(Enumerators.GetEnumDescription(Cash.Answer10));
            }
        }

        public int getCurrentCash()
        {
            return int.Parse(Enumerators.GetEnumDescription((Cash)(questionCounter)));

        }

        public List<string> useHalfHalfHelp(string rightAnswer)
        {
            string[] answers = new string[4] { "A", "B", "C", "D" };
            var answersWithOutRightOne = answers.Where(x => !x.Equals(rightAnswer)).ToList();
            Random random = new Random();
            int randomIndex = random.Next(answersWithOutRightOne.Count);
            answersWithOutRightOne.RemoveAt(randomIndex);
            return answersWithOutRightOne;
        }

        public List<string> useAskAudienceHelp(string rightAnswer)
        {
            string[] answers = new string[4] { "A", "B", "C", "D" };
            List<string> answerPercetages = new List<string>();
            Random random = new Random();

            var percetanges = 100;
            var rightAnswerPercetages = 1;

            if (questionCounter <= 5)
            {
                rightAnswerPercetages = 90;
            }
            else if (questionCounter > 5 && questionCounter <= 9)
            {
                rightAnswerPercetages = 70;
            }
            else if (questionCounter > 9 && questionCounter <= 11)
            {
                rightAnswerPercetages = 55;
            }
            else if (questionCounter > 11 && questionCounter <= 13)
            {
                rightAnswerPercetages = 40;
            }
            else if (questionCounter > 13 && questionCounter <= 15)
            {
                rightAnswerPercetages = 35;
            }

            percetanges = percetanges - rightAnswerPercetages;
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i].Equals(rightAnswer))
                {
                    answerPercetages.Add(rightAnswerPercetages.ToString());
                }
                else
                {
                    if (i + 1 == answers.Length)
                        answerPercetages.Add(percetanges.ToString());
                    else
                    {
                        var randomPercetage = random.Next(0, percetanges - 2);
                        answerPercetages.Add(randomPercetage.ToString());
                        percetanges = percetanges - randomPercetage;
                    }
                }

            }

            return answerPercetages;
        }

        public string userAskFriendHelp(string rightAnswer)
        {

            if (questionCounter <= 5)
            {
                return "The answer is " + rightAnswer + "." + " Iam 100% sure!";
            }
            else if (questionCounter > 5 && questionCounter <= 9)
            {
                return "Hmm..I guess the answer is " + rightAnswer + "." + " Iam 90% sure!";
            }
            else if (questionCounter > 9 && questionCounter <= 11)
            {
                return "Hmm..I guess the answer is " + rightAnswer + "." + " Iam 70% sure!";
            }
            else if (questionCounter > 11 && questionCounter <= 13)
            {
                return "Hmm..I guess the answer is" + rightAnswer + ".\nIam 50% sure!";
            }
            else //if (questionCounter > 13 && questionCounter <= 15)
            {
                Random random = new Random();
                var randomLuck = random.Next(0, 1);
                if (randomLuck == 1)
                    return "Hmm..Let me see.. \nI think the answer is" + rightAnswer + ".\nBut I'm not so sure!";
                else
                {
                    randomLuck = random.Next(0, 1);
                    if (randomLuck == 0)
                        return "Sorry mate, I have no idea!";
                    else
                    {
                        string[] answers = new string[4] { "A", "B", "C", "D" };
                        int randomIndex = random.Next(answers.Length);
                        return "Hmm..Let me see.. \nI think the answer is" + answers[randomIndex] + ".\nBut I'm not so sure!";
                    }
                }
            }
        }

        public void getQuestionData()
        {
            string fileName = "questions.xml";
            var CurrentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            questions = Helpers.XMLHelper.ReadXml<Questions>(Path.Combine(CurrentDirectory, fileName)).Question;
        }
    }
}
