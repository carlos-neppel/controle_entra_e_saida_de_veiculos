using System.Windows;
using System.Windows.Controls;
using Controllers;
using Modelos;

namespace WpfView
{
    /// <summary>
    /// Interaction logic for Tela_Lista_Morador.xaml
    /// </summary>
    public partial class Tela_Lista_Morador : Window
    {
        public Tela_Lista_Morador()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MoradoresControle moradoresControle = new MoradoresControle();
            dgMoradores.ItemsSource = moradoresControle.ListarTodos();
        }
        private void dgMoradores_SelectionChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);
            Morador mor = (Morador)dg.Items[dg.SelectedIndex];
        }
    }
}
