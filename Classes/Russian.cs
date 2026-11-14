using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Human_Vyalykh.Classes
{
    public class Russian : Human
    {
        private List<Phrase> Phrases {  get; set; }
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
        public Russian(string Name, string Img) : base(Name, Img)
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
            allPhrases.Add(new Phrase("Привет", @"\Voices\eeeb1b62a55026e0ed91877e9e6da41f.mp3"));
            allPhrases.Add(new Phrase("Как дела?", @"\Voices\17eb82db6809568fc8775d1c9890e578.mp3"));
            allPhrases.Add(new Phrase("Меня зовут Александра", @"\Voices\9b54b53a5277e66ffb6cad56fbb781b0.mp3"));
            return allPhrases;
        }

    }
}
