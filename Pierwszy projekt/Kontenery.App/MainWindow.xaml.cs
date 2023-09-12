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

namespace Kontenery.App
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

        private void ButtonWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelWindow wrapPanelWindow = new WrapPanelWindow();
            wrapPanelWindow.Show();
        }

        private void ButtonStackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow stackPanelWindow = new StackPanelWindow();
            stackPanelWindow.Show();

        }


        private void ButtonDockPanel_Click(object sender, RoutedEventArgs e)
        {
            DockPanelWindow DockPanelWindow = new DockPanelWindow();
            DockPanelWindow.Show();

        }
        private void ButtonGridPanel_Click(object sender, RoutedEventArgs e)
        {
            GridPanelWindow GridPanelWindow = new GridPanelWindow();
            GridPanelWindow.Show();

        }


    }
}
