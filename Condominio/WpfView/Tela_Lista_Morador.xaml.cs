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
        }
    }
}
