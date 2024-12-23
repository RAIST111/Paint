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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isDrawing;
        private int currentTool = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isDrawing = true;
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isDrawing = false;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing) 
            { 
                Draw(e.GetPosition(CnvPaint));
            }

        }
        private void Draw(Point position)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Fill = Brushes.Gainsboro;
            ellipse.Width = 10;
            ellipse.Height = 10;
            Canvas.SetTop(ellipse, position.Y);
            Canvas.SetLeft(ellipse, position.X);
            CnvPaint.Children.Add(ellipse);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BtnDrip.Background = Brushes.LightGray;
            BtnRubber.Background = Brushes.LightGray;
            BtnPencil.Background = Brushes.LightGray;
            Button button = (Button)sender;
            button.Background = Brushes.Yellow;
            if (button == BtnPencil)
            {
                SliderSize.Visibility = Visibility.Visible;
                ColorPicker.Visibility = Visibility.Visible;
                currentTool = 1;
            }

            if (button == BtnRubber)
            {
                SliderSize.Visibility = Visibility.Visible;
                ColorPicker.Visibility = Visibility.Visible;
                currentTool = 1;
            }
            if (button == BtnDrip)
            {
                SliderSize.Visibility= Visibility.Visible;  
                ColorPicker.Visibility = Visibility.Visible;
                currentTool = 2;
            }
                
            
        }
    }
}
