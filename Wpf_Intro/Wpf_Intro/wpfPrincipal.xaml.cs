using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Speech.Synthesis; //agregado

namespace Wpf_Intro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnEnviarSaludo_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer sp= new SpeechSynthesizer();
            sp.Volume=100;
            sp.Speak("Hola"+txtNombre+"Bienvenido al algoritmo");
           
        }
    }
}
