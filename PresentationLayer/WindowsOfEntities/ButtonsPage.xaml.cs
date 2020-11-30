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
    /// Логика взаимодействия для ButtonsPage.xaml
    /// </summary>
    public partial class ButtonsPage : Page
    {
        public ButtonsPage()
        {
            InitializeComponent();
        }
        private void ActionsButtonClick(object sender, RoutedEventArgs e)
        {
            ActionsWindow actionsWindow = new ActionsWindow();
            actionsWindow.Show();
        }
        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
