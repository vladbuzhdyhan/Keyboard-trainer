using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string text;
        private string input;
        private int counter = -1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //start
        {
            buttonStart.IsEnabled = false;
            buttonStop.IsEnabled = true;
            textBox.Text = "qwerty";
            textBox2.IsEnabled = true;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //stop
        {
            buttonStart.IsEnabled = true;
            buttonStop.IsEnabled = false;
            textBox.Text = null;
            textBox2.Text = null;
            text = null;
            input = null;
            textBox2.IsEnabled = false;
            textBox.Background = Brushes.White;
        }

        private void textBox2_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Q: _q.Background = Brushes.Bisque; input += 'q'; counter++; break;
                case Key.W: _w.Background = Brushes.Bisque; input += 'w'; counter++; break;
                case Key.E: _e.Background = Brushes.Bisque; input += 'e'; counter++; break;
                case Key.R: _r.Background = Brushes.Bisque; input += 'r'; counter++; break;
                case Key.T: _t.Background = Brushes.Bisque; input += 't'; counter++; break;
                case Key.Y: _y.Background = Brushes.Bisque; input += 'y'; counter++; break;
                case Key.U: _u.Background = Brushes.Bisque; input += 'u'; counter++; break;
                case Key.I: _i.Background = Brushes.Bisque; input += 'i'; counter++; break;
                case Key.O: _o.Background = Brushes.Bisque; input += 'o'; counter++; break;
                case Key.P: _p.Background = Brushes.Bisque; input += 'p'; counter++; break;
                case Key.Back:
                    if (input.Length != 0)
                    {
                        input = input.Remove(input.Length - 1);
                        counter--;
                        Backspace.Background = Brushes.Bisque;
                    }
                    break;
            }

            if (e.Key == Key.Back)
            {
                if (text.Length != 0) {
                    text = text.Remove(text.Length - 1);
                }
            }
            else
            {
                if (textBox.Text.Length > counter)
                {
                    text += textBox.Text[counter];
                }
                else
                {
                    text += ' ';
                }
            }

            if (text != input)
            {
                textBox.Background = Brushes.Bisque;
            }
            else
            {
                textBox.Background = Brushes.White;
            }

        }

        private void textBox2_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Q: _q.Background = Brushes.White; break;
                case Key.W: _w.Background = Brushes.White; break;
                case Key.E: _e.Background = Brushes.White; break;
                case Key.R: _r.Background = Brushes.White; break;
                case Key.T: _t.Background = Brushes.White; break;
                case Key.Y: _y.Background = Brushes.White; break;
                case Key.U: _u.Background = Brushes.White; break;
                case Key.I: _i.Background = Brushes.White; break;
                case Key.O: _o.Background = Brushes.White; break;
                case Key.P: _p.Background = Brushes.White; break;
                case Key.Back: Backspace.Background = Brushes.White; break;
            }
        }
    }
}
