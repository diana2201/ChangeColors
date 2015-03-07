using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ChangeColor.Resources;
using System.Windows.Media;

namespace ChangeColor
{
    public partial class MainPage : PhoneApplicationPage
    {
        int a = 0;
        int az = 0;
        int r = 0;
        // Constructor
        public MainPage()
        {
            InitializeComponent();


            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }


        //Inicio Métodos para RadioButton, Selección de color único
        private void RBama(object sender, RoutedEventArgs e)
        {
            RecRad.Fill = new SolidColorBrush(Colors.Yellow);
        }

        private void RBazul(object sender, RoutedEventArgs e)
        {
            RecRad.Fill = new SolidColorBrush(Colors.Blue);
        }

        private void RBrojo(object sender, RoutedEventArgs e)
        {
            RecRad.Fill = new SolidColorBrush(Colors.Red);
        }

       //Fin Métodos para RadioButton, Selección de color único

        private void CBox()
        {
            if (a==1 && az==1 && r==1)
            {
                RecCheck.Fill = new SolidColorBrush(Colors.White);
            }
            if (a == 0 && az == 0 && r == 0)
            {
                RecCheck.Fill = new SolidColorBrush(Colors.Black);
            }
            if (a == 1 && az == 0 && r == 0)
            {
                RecCheck.Fill = new SolidColorBrush(Colors.Yellow);
            }
            if (a == 1 && az == 1 && r == 0)
            {
                RecCheck.Fill = new SolidColorBrush(Colors.Green);
            }
            if (a == 1 && az == 0 && r == 1)
            {
                RecCheck.Fill = new SolidColorBrush(Colors.Orange);
            }
            if (a == 0 && az == 1 && r == 0)
            {
                RecCheck.Fill = new SolidColorBrush(Colors.Blue);
            }
            if (a ==0  && az == 1 && r == 1)
            {
                RecCheck.Fill = new SolidColorBrush(Colors.Purple);
            }
            if (a == 0 && az == 0 && r == 1)
            {
                RecCheck.Fill = new SolidColorBrush(Colors.Red);
            }
        }

        private void CBama(object sender, RoutedEventArgs e)
        {
            if (a == 1)
            {
                a = 0;
                CBox();
            }
            else
            {
                a = 1;
                CBox();
            }
        }

        private void CBazul(object sender, RoutedEventArgs e)
        {
            if (az == 1)
            {
                az = 0;
                CBox();
            }
            else
            {
                az = 1;
                CBox();
            }
        }

        private void CBrojo(object sender, RoutedEventArgs e)
        {
            if (r == 1)
            {
                r = 0;
                CBox();
            }
            else
            {
                r = 1;
                CBox();
            }
        }

    }
}