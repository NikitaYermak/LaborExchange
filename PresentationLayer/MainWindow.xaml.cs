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
using PresentationLayer.WindowsOfEntities;

namespace PresentationLayer
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
        private void MenuCustomer_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CustomerPage());
        }
        private void MenuSummary_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SummaryPage());
        }
        private void MenuUnemployed_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new UnemployedPage());
        }
        private void MenuVacancy_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new VacancyPage());
        }
    }
}
