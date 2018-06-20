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

namespace WpfView
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

        private void btnCadastroMorador_Click(object sender, RoutedEventArgs e)
        {
            Tela_CadastroMorador cadMor = new Tela_CadastroMorador();

            cadMor.ShowDialog();
        }

        private void btnCadastroVisitante_Click(object sender, RoutedEventArgs e)
        {
            Tela_CadastroVisitante cadVis = new Tela_CadastroVisitante();
            cadVis.ShowDialog();
        }

        private void btnVisualizarMorador_Click(object sender, RoutedEventArgs e)
        {
            Tela_Lista_Morador cadLisM = new Tela_Lista_Morador();
            cadLisM.ShowDialog();
        }
    }
}
