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
    /// Логика взаимодействия для CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        public CustomerPage()
        {
            InitializeComponent();
        }
        private void ActionsButton(object sender, RoutedEventArgs e) 
        {
            ActionsWindow actionsWindow = new ActionsWindow();
            actionsWindow.Show();
        }
        private void AddButton(object sender, RoutedEventArgs e)
        {

        }
        private void EditButton(object sender, RoutedEventArgs e)
        {

        }
        private void ShowAllButton(object sender, RoutedEventArgs e)
        {

        }
        private void ClearButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
