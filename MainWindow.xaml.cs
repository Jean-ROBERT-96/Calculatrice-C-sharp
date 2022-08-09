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

namespace Calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string affichage = "0";
        List<long> nombre;
        List<string> operateur;
        string saisie = "0";

        public MainWindow()
        {
            InitializeComponent();
            nombre = new List<long>();
            operateur = new List<string>();
        }

        public void Ecran()
        {
            Affichage.Text = affichage;
        }

        public void Calcul()
        {
            operateur.Insert(0, "+");
            long result = 0;
            try
            {
                for (int i = 0; i <= nombre.Count; i++)
                {
                    switch (operateur.ElementAt(i))
                    {
                        case "+":
                            result += nombre.ElementAt(i);
                            break;
                        case "-":
                            result -= nombre.ElementAt(i);
                            break;
                        case "x":
                            result *= nombre.ElementAt(i);
                            break;
                        case "/":
                            result /= nombre.ElementAt(i);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                Affichage.Text = "Erreur";
            }
            Affichage.Text = result.ToString();

            result = 0;
            affichage = "0";
            saisie = "0";
            nombre.Clear();
            operateur.Clear();
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            affichage += "0";
            saisie += "0";
            Ecran();
        }

        private void Un_Click(object sender, RoutedEventArgs e)
        {
            affichage += "1";
            saisie += "1";
            Ecran();
        }

        private void Deux_Click(object sender, RoutedEventArgs e)
        {
            affichage += "2";
            saisie += "2";
            Ecran();
        }

        private void Trois_Click(object sender, RoutedEventArgs e)
        {
            affichage += "3";
            saisie += "3";
            Ecran();
        }

        private void Quatre_Click(object sender, RoutedEventArgs e)
        {
            affichage += "4";
            saisie += "4";
            Ecran();
        }

        private void Cinq_Click(object sender, RoutedEventArgs e)
        {
            affichage += "5";
            saisie += "5";
            Ecran();
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            affichage += "6";
            saisie += "6";
            Ecran();
        }

        private void Sept_Click(object sender, RoutedEventArgs e)
        {
            affichage += "7";
            saisie += "7";
            Ecran();
        }

        private void Huit_Click(object sender, RoutedEventArgs e)
        {
            affichage += "8";
            saisie += "8";
            Ecran();
        }

        private void Neuf_Click(object sender, RoutedEventArgs e)
        {
            affichage += "9";
            saisie += "9";
            Ecran();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            affichage += " + ";
            operateur.Add("+");
            nombre.Add(long.Parse(saisie));
            saisie = "0";
            Ecran();
        }

        private void Moins_Click(object sender, RoutedEventArgs e)
        {
            affichage += " - ";
            operateur.Add("-");
            nombre.Add(long.Parse(saisie));
            saisie = "0";
            Ecran();
        }

        private void Multiplier_Click(object sender, RoutedEventArgs e)
        {
            affichage += " x ";
            operateur.Add("x");
            nombre.Add(long.Parse(saisie));
            saisie = "0";
            Ecran();
        }

        private void Divise_Click(object sender, RoutedEventArgs e)
        {
            affichage += " / ";
            operateur.Add("/");
            nombre.Add(long.Parse(saisie));
            saisie = "0";
            Ecran();
        }

        private void Effacer_Click(object sender, RoutedEventArgs e)
        {
            affichage = "0";
            saisie = "0";
            nombre.Clear();
            operateur.Clear();
            Ecran();
        }

        private void Egal_Click(object sender, RoutedEventArgs e)
        {
            nombre.Add(long.Parse(saisie));
            Calcul();
        }
    }
}
