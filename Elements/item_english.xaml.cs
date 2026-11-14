using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Human_Vyalykh.Elements
{
    /// <summary>
    /// Логика взаимодействия для item_english.xaml
    /// </summary>
    public partial class item_english : UserControl
    {
        Classes.Human Human;
        public item_english(object Data)
        {
            InitializeComponent();
            this.Human = Data as Classes.Human;
            img.Source = new BitmapImage(new Uri(this.Human.Img, UriKind.RelativeOrAbsolute));
            name.Content = this.Human.Name;
            lrace.Content = Data.GetType().Name;
        }
        private void Speak(object sender, MouseButtonEventArgs e)
        {
            Human.Speak(text);
        }
    }
}
