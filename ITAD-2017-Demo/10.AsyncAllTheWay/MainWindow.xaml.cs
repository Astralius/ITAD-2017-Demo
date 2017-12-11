using System.Threading.Tasks;
using System.Windows;

namespace AsyncAllTheWay
{
    /// <summary>
    /// 
    /// 
    /// Usage:
    /// 0. Set this project as StartUp project.
    /// 1. Start the program (F5). 
    /// 
    /// Explaination:
    /// 
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
