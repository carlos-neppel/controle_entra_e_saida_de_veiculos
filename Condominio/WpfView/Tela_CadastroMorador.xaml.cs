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
    /// Interaction logic for Tela_CadastroMorador.xaml
    /// </summary>
    public partial class Tela_CadastroMorador : Window
    {
        public Tela_CadastroMorador()
        {
            InitializeComponent();
        }

        //  radmorador para verificar se o cadastro é de morador 
        private void RadMorador_Checked(object sender, RoutedEventArgs e)
        {
           
        }

       // para veficar se o morador se encontra em casa
        private void RadStatusM_S_Checked(object sender, RoutedEventArgs e)
        {
            RadStatusM_S.Visibility = Visibility.Hidden;
        }
        // para veficar se o morador não  se encontra em casa
        private void RadStatusM_N_Checked(object sender, RoutedEventArgs e)
        {
            RadStatusM_N.Visibility = Visibility.Hidden;
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MoradoresControle moradoresControle = new MoradoresControle();

                if (string.IsNullOrEmpty(txtPlacaM.Text))
                    throw new NullReferenceException("o campo placa é obrigatorio!");

                Morador morador = new Morador();

                morador.PlacaMId = txtPlacaM.Text;
                morador.CarroM = txtCarroM.Text;
                morador.NomeM = txtNome.Text;
                morador.TelefoneM = txtTelefoneM.Text;
                morador.Casa_numM = txtCasa_numM.Text;

                moradoresControle.Adicionar(morador);
                MessageBox.Show("Cadastro Realizado como sucesso");

            }
                catch
            {
                //MessageBox.Show("Erro ao Salvar( " + Ex.Message +")");
            }
            




        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
