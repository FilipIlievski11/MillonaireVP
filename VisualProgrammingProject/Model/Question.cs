using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingProject.Model
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Questions
    {

        private QuestionsQuestion[] questionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Question")]
        public QuestionsQuestion[] Question
        {
            get
            {
                return this.questionField;
            }
            set
            {
                this.questionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class QuestionsQuestion
    {

        private string questionTextField;

        private string answerAField;

        private string answerBField;

        private string answerCField;

        private string answerDField;

        private string rightAnswerField;

        private byte numberField;

        /// <remarks/>
        public string QuestionText
        {
            get
            {
                return this.questionTextField;
            }
            set
            {
                this.questionTextField = value;
            }
        }

        /// <remarks/>
        public string AnswerA
        {
            get
            {
                return this.answerAField;
            }
            set
            {
                this.answerAField = value;
            }
        }

        /// <remarks/>
        public string AnswerB
        {
            get
            {
                return this.answerBField;
            }
            set
            {
                this.answerBField = value;
            }
        }

        /// <remarks/>
        public string AnswerC
        {
            get
            {
                return this.answerCField;
            }
            set
            {
                this.answerCField = value;
            }
        }

        /// <remarks/>
        public string AnswerD
        {
            get
            {
                return this.answerDField;
            }
            set
            {
                this.answerDField = value;
            }
        }

        /// <remarks/>
        public string RightAnswer
        {
            get
            {
                return this.rightAnswerField;
            }
            set
            {
                this.rightAnswerField = value;
            }
        }

        /// <remarks/>
        public byte Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }


}
