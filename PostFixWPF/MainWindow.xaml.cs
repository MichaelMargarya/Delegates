using System.Linq.Expressions;
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


namespace PostFixWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Esa exp = new Esa();
            try
            {
                string expression =quest.Text;
                double result =exp.Calculate(expression);
                patas.Text ="Reslut: " + result.ToString();
                
            }
            catch (Exception ex)
            {
                patas.Text = "Error: " + ex.Message;
            }

        }
    }
}