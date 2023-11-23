using System;
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

namespace _13
{
    /// <summary>
    /// Логика взаимодействия для SalonPage.xaml
    /// </summary>
    public partial class SalonPage : Page
    {
        public SalonPage()
        {
            InitializeComponent();
            cbservice.ItemsSource = ClassHelper.services;
            cbservice.DisplayMemberPath = "NameService";
            cbservice.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Service service = new Service();
            service.Date = dpdateService.Text;
            service.NameClient = tbnameClient.Text;
            service.NameService = cbservice.Text;


            ClassHelper.services.Add(service);
            MessageBox.Show("Клиент добавлен");
        }
    }
}
