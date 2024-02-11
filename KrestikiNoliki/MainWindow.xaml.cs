using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KrestikiNoliki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int Player;
        private Random Random;
        private Button[,] buttons;
        public MainWindow()
        {
            InitializeComponent();
            Player = 1;
            Random = new Random();
           
            

        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            Button1.IsEnabled = true;
            Button1.Content = "";
            Button2.IsEnabled = true;
            Button2.Content = "";
            Button3.IsEnabled = true;
            Button3.Content = "";
            Button4.IsEnabled = true;
            Button4.Content = "";
            Button5.IsEnabled = true;
            Button5.Content = "";
            Button6.IsEnabled = true;
            Button6.Content = "";
            Button7.IsEnabled = true;
            Button7.Content = "";
            Button8.IsEnabled = true;
            Button8.Content = "";
            Button9.IsEnabled = true;
            Button9.Content = "";


        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (Player)
            {
                case 1:
                    Button buttonX = (Button)sender;
                    buttonX.Content = "X";
                    buttonX.IsEnabled = false;          
                    Player = 0;
                    break;

                case 0:
                    Button buttonO = (Button)sender;
                    buttonO.Content = "O";
                    buttonO.IsEnabled = false;
                    Player = 1;
                    break;
            }
            If_Win();



        }
        private void If_Win() 
        //горизонтальный выйгрыш//
        {
            if (Button1.Content == Button2.Content && Button2.Content == Button3.Content) 
            {
                if (Button1.Content != "")
                MessageBox.Show("О, УРА пОБЕДа!");
            
            }
            if (Button4.Content == Button5.Content && Button5.Content == Button6.Content)
            {
                if (Button4.Content != "")
                    MessageBox.Show("О, УРА пОБЕДа!");

            }
            if (Button7.Content == Button8.Content && Button8.Content == Button9.Content)
            {
                if (Button7.Content != "")
                    MessageBox.Show("О, УРА пОБЕДа!");

            }
            //вертикальный выйгрыш//
            if (Button1.Content == Button4.Content && Button4.Content == Button7.Content)
            {
                if (Button1.Content != "")
                    MessageBox.Show("О, УРА пОБЕДа!");

            }
            if (Button2.Content == Button5.Content && Button5.Content == Button8.Content)
            {
                if (Button2.Content != "")
                    MessageBox.Show("О, УРА пОБЕДа!");

            }
            if (Button3.Content == Button6.Content && Button6.Content == Button9.Content)
            {
                if (Button3.Content != "")
                    MessageBox.Show("О, УРА пОБЕДа!");

            }
            //диагональный выйгрыш//
            if (Button1.Content == Button5.Content && Button5.Content == Button9.Content)
            {
                if (Button1.Content != "")
                    MessageBox.Show("О, УРА пОБЕДа!");

            }
            if (Button3.Content == Button5.Content && Button5.Content == Button7.Content)
            {
                if (Button3.Content != "")
                    MessageBox.Show("О, УРА пОБЕДа!");

            }
            

      
        }
       

















    }   


}
