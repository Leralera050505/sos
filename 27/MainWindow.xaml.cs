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

namespace _27
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lwCar.ItemsSource = Car.cars;
            foreach (var item in Car.cars)
            {
                Car.CheckAge(item.Age);
                Car.CheckNumber(item.Number);
                Car.CheckNameCar(item.NameCar);
                Car.CheckDateService(item.DateService);
                Car.CheckFIO(item.FIO);
            }
        }
    }
}