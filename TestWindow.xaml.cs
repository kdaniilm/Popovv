﻿using System;
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
using System.Windows.Shapes;

namespace Popovv
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        Test test = new Test();
        int i = 0;
        string x = string.Empty;
        public TestWindow(string TestClass)
        {
            InitializeComponent();
            switch (TestClass)
            {
                case ("science"):
                    x = "science";
                    test.CreateSciense();
                    TextTb.Text = test.Sciense[i].Quetion;
                    Button1.Content = test.Sciense[i].Right;
                    Button2.Content = test.Sciense[i].Wrong;
                    break;
                case ("med"):
                    x = "med";
                    test.CreateScienseMed();
                    TextTb.Text = test.Med[i].Quetion;
                    Button1.Content = test.Med[i].Right;
                    Button2.Content = test.Med[i].Wrong;
                    break;
                case ("it"):
                    x = "it";
                    test.CreateScienseIt();
                    TextTb.Text = test.It[i].Quetion;
                    Button1.Content = test.It[i].Right;
                    Button2.Content = test.It[i].Wrong;
                    break;
            }
            ImageSourceConverter converter = new ImageSourceConverter();
            
            //ImageImg.Source = ((ImageSource)converter.ConvertFromString("Resources/"+ TestClass +".jpg"));
        }

        
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("True");
            i++;
            X(x, i);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("False");
            i++;
            X(x, i);
        }
        private void X(string TestClass, int i)
        {
            if (i < 6)
            {
                switch (TestClass)
                {
                    case ("science"):
                        i++;
                        TextTb.Text = test.Sciense[i].Quetion;
                        Button1.Content = test.Sciense[i].Right;
                        Button2.Content = test.Sciense[i].Wrong;
                        break;
                    case ("med"):
                        TextTb.Text = test.Med[i].Quetion;
                        Button1.Content = test.Med[i].Right;
                        Button2.Content = test.Med[i].Wrong;
                        break;
                    case ("it"):
                        TextTb.Text = test.It[i].Quetion;
                        Button1.Content = test.It[i].Right;
                        Button2.Content = test.It[i].Wrong;
                        break;
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
