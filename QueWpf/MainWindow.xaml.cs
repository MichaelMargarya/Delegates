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

namespace QueWpf
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
        Random random = new Random();
        MyQueue<int> queue = new MyQueue<int>();
        
        private void Enqueue(object sender, RoutedEventArgs e)
        {
            queue.Enqueue(random.Next(0,200));
            updateGrid();
        }

        private void Dequeue(object sender, RoutedEventArgs e)
        {
            queue.Enqueue();
        }
        private void updateGrid()
        {
            Label1.Content = string.Empty;
            Label2.Content = string.Empty;
            Label3.Content = string.Empty;
            Label4.Content = string.Empty;
            Label5.Content = string.Empty;  
            Label6.Content = string.Empty;

            int index = 0;
            foreach(int message in queue )
            {
                switch(index)
                {
                    case 0:
                        Label1.Content = message.ToString();
                        break;
                        case 1:
                        Label2.Content = message.ToString();
                        break;
                        case 2:
                        Label3.Content = message.ToString();

                        break;
                        case 3:
                        Label4.Content = message.ToString();
                        break;
                        case 4:
                        Label5.Content = message.ToString();
                        break;
                        case 5:
                        Label6.Content = message.ToString();
                        break;
                }
                index++;
                if (index > 5)
                {
                    break;
                }

                }
            }
        }
    }
}