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
using Modelos;

namespace WpfView
{
    /// <summary>
    /// Interaction logic for Tela_CadastroVisitante.xaml
    /// </summary>
    public partial class Tela_CadastroVisitante : Window
    {
        public Tela_CadastroVisitante()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try {
                VisitantesControle visiranteControle = new VisitantesControle();

                if (String.IsNullOrEmpty(txtPlacaV.Text))
                    throw new NullReferenceException("o campo placa é obrigatorio");

                Visitante visitante = new Visitante();

                visitante.PlacaVId = txtPlacaV.Text;
                visitante.CarroV = txtCarroV.Text;
                visitante.NomeV = txtNomeV.Text;
                visitante.TelefoneV = txtTelefoneV.Text;
                visitante.Visita = txtVisita.Text;

                visiranteControle.Adicionar(visitante);
                MessageBox.Show("cadastro realizado com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("erro ao salvar(" + ex.Message + ")");
            }
           

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
