using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Human_Vyalykh.Classes
{
    public class English : Human
    {
        private List<Phrase> Phrases { get; set; }
        private int stepAudio;
        private int StepAudio
        {
            get { return stepAudio; }
            set
            {
                stepAudio = value;
                if (stepAudio > Phrases.Count - 1)
                    stepAudio = 0;
            }
        }
        public English(string Name, string Img) : base(Name, Img)
        {
            this.Phrases = AllPhrases();
        }
        public override void Speak(Label Phrase)
        {
            Phrase.Content = Phrases[StepAudio]._Phrase;
            MainWindow.MediaPlayer.Open(new Uri(Phrases[StepAudio].Src, UriKind.Relative));
            MainWindow.MediaPlayer.Play();
            StepAudio++;
        }
        public static List<Phrase> AllPhrases()
        {
            List<Phrase> allPhrases = new List<Phrase>();
            allPhrases.Add(new Phrase("Hello", @"\Voices\hello.mp3"));
            allPhrases.Add(new Phrase("How are you?", @"\Voices\howareyou.mp3"));
            allPhrases.Add(new Phrase("My name is Alexandra", @"\Voices\mynameis.mp3"));
            return allPhrases;
        }
    }
}
