using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ComandosYMenus
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<TextBlock> lista = new ObservableCollection<TextBlock>();
        public MainWindow()
        {
            InitializeComponent();
            listaItems_Listbox.DataContext = lista;
        }
        

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (lista.Count < 10)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Item añadido a las " + DateTime.Now.ToLongTimeString();
            lista.Add(textBlock);
        }
    }
}
