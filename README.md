# MillonaireVP


Упатство за користење 

Откако ќе го симнете изворниот код, пуштете го проектот во Visual Studio и билднете го проектот. 
Откако ќе ви се креира фолдер bin/debug, ископирајте ги xml fajlovite od Resources/XMLData во bin/debug.
Фајловите кои треба да ги ископирате се highscores.xml и questions.xml
Потоа може да ја пуштите играта.

Играта е класичен квиз со праша познат под името Кој сака да биде милионер.

На почетокот треба задолжително да го внесете вашето име.
https://imgur.com/0VIU5uJ
Кликнувате на нова игра и квизот започнува.
https://imgur.com/i91Qkvc
Имате петнаесет прашања и вие ги одговарате прашањата точно едно по едно.
Доколку некое не го знаете можете да употребите три помагала:
Повикај пријател, Пола-Пола , прашај публика.
Во секој момент може да се откажете и освоите извесен износ што го имате до таму освоено.
Доколу ги одоговорите сите добивате милион, а ако згрешите паѓате на сумата што ја имате освоено:
Ако сте биле над 5то прашање ја добивате сумата од 5тото, над 10то сумата од 10тото.
Вашиот учинок се зачувува и ако сте во топ 5 ќе можете да проверите во формата HighScores.
https://imgur.com/qGYqHS2

За чување на податоците користев xml фајлови,тие се лоцирани во bin/debug и преку генерички функции за читање ги читам соодветните податоци за различни класи 
под истото име. 
Пример за класата за прашања.
    
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class HighScore
    {

        private HighScoreScore[] scoreField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Score")]
        public HighScoreScore[] Score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HighScoreScore
    {

        private string usernameField;

        private uint scoreField;

        /// <remarks/>
        public string Username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        /// <remarks/>
        public uint Score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
            }
        }
    }
    
Има класа Game која ја иницира играта. Во неа ги зимам прашањата и ги чувам во текот на играта и имам бројач до каде е стасан играчпт,преку таа класа оди целата логика на апликацијата. 
Со секое ново прашање ја повикувам функцијата getAQuestion() која ми враќа рандом прашање на формата од 
зависност на кое ниво е стасан играчот. Секое прашање си има свој левел од 1 до 15. И на пример од низата на прашања
со ниво 3, рандом се одбира едно кое ќе се врати на формата за играчот да го одговори.
Пола-Пола - преку функцијата useHalfHalfHelp го тргам точниот одговор а другите две ги бирам рандом за да се исклучат.
Повикај пријател - преку фунцкијата userAskFriendHelp го гледам бројачот и доколку е на потешките прашања, пријателот се помалку знае, а на крајните 14,15 може или рандом да излаже или да не го знае одговорот.
Прашај Публика - useAskAudienceHelp го гледам пак бројачот одредувам според тежината на прашањето колку да бидат процентите на точниот одговор а другите проценти се рандом.
Користам класа за звуци Sounds кои ги чувам во ресурси, и повеќето интеракции си имаат свои звуци кои наликуваат на оригиналниот квиз од тв.




    
