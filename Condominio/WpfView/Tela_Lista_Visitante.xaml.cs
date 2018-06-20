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
using System.Windows.Shapes;
using Controllers;

namespace WpfView
{
    /// <summary>
    /// Interaction logic for Tela_Lista_Visitante.xaml
    /// </summary>
    public partial class Tela_Lista_Visitante : Window
    {
        public Tela_Lista_Visitante()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VisitantesControle visitanteControle = new VisitantesControle();
            dgVisitantes.ItemsSource = visitanteControle.ListarTodos();
        }
    }
}