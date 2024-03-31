using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup.Localizer;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyQueueWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Count { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

            Random rand = new Random();
            MyQueue<int> Inqna = new MyQueue<int>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
         Inqna.Enqueue(rand.Next(0,200));
         UpdateGrid();
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Inqna.Count > 0)
            {
                lisbox.Items.Add(num1.Content);
                Inqna.Dequeue();
            }
        }
        public void UpdateGrid()
        {
            num1.Content = string.Empty;
            num2.Content = string.Empty;
            num3.Content = string.Empty;
            num4.Content = string.Empty;
            num5.Content = string.Empty;
            num6.Content = string.Empty;

            int index = 0;

            foreach(int message in Inqna)
            {
                switch(index)
                {
                    case 0:
                        num1.Content = message.ToString();
                        break;
                        case 1:
                        num2.Content = message.ToString();
                        break;
                        case 2:
                        num3.Content = message.ToString();
                        break;
                        case 3:
                        num4.Content = message.ToString();
                        break;
                        case 4:
                        num5.Content = message.ToString();
                        break;
                        case 5:
                            num6.Content = message.ToString();
                        break;

                }
                index++;
                if(index>5)
                {
                    break;
                }    
            }
        }

    }
}