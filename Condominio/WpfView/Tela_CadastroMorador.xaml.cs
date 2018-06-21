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
        private void BtnSalvar_Click(object sender, RoutedEventArgs e)

        {
            try
            {
                MoradoresControle moradoresControle = new MoradoresControle();

                if (string.IsNullOrEmpty(txtPlacaM.Text))
                    throw new NullReferenceException("o campo placa é obrigatorio!");

                Morador morador = new Morador();


                morador.PresencaM = txtPresencaM.Text;
                morador.PlacaMId = txtPlacaM.Text;
                morador.CarroM = txtCarroM.Text;
                morador.NomeM = txtNome.Text;
                morador.TelefoneM = txtTelefoneM.Text;
                morador.Casa_numM = txtCasa_numM.Text;
                morador.StatusM = txttatusM.Text;

                moradoresControle.Adicionar(morador);
                MessageBox.Show("Cadastro Realizado como sucesso");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao Salvar( " + ex.Message +")");
            }
            




        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
