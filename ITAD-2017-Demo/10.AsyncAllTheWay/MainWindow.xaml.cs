using System.Threading.Tasks;
using System.Windows;

namespace AsyncAllTheWay
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
            HandleExecution();
        }

        private static async Task ExecuteHeavyLogic()
        {
            await Task.Delay(4000);
            //......
        }
            
        private static void HandleExecution()
        {
            var executionResult = ExecuteHeavyLogic();
            executionResult.Wait();
        }
    }
}
