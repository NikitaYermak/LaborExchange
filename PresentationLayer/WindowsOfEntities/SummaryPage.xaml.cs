using System;
using System.Collections.Generic;
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

namespace PresentationLayer.WindowsOfEntities
{
    /// <summary>
    /// Логика взаимодействия для SummaryPage.xaml
    /// </summary>
    public partial class SummaryPage : Page
    {
        public SummaryPage()
        {
            InitializeComponent();
        }
        private void ActionsButtonClick(object sender, RoutedEventArgs e)
        {
            ActionsWindow actionsWindow = new ActionsWindow();
            actionsWindow.Show();
        }
        private void AddButtonClick(object sender, RoutedEventArgs e)
        {

        }
        private void EditButtonClick(object sender, RoutedEventArgs e)
        {

        }
        private void ShowAllButtonClick(object sender, RoutedEventArgs e)
        {

        }
        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
