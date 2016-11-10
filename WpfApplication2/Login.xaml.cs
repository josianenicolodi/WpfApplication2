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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        GerenciadorDeUsuarios gerenciador;

        public Login()
        {
            InitializeComponent();
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {

        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            gerenciador = new GerenciadorDeUsuarios();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string nome;
            string senha;

            nome = txNome.Text;
            senha = txSenha.Password;


            Usuario user;

            if (gerenciador.ExisteUsuario(nome))
            {
                user = gerenciador.GetUsuario(nome);
                if(senha == user.Senha)
                {
                    MainWindow janela = new MainWindow(user);
                    janela.Show();
                    this.Close();
                }else
                {
                    LbError.Content = "Senha Incorreta!";
                }
            }else
            {
                LbError.Content = "Usuario não cadastrado!";
            }


        }

        private void txNome_TextChanged(object sender, TextChangedEventArgs e)
        {
            LbError.Content = "";

        }


        private void btCriarconta_Click(object sender, RoutedEventArgs e)
        {
            CadastroUsuario cadastro;

            cadastro = new CadastroUsuario();

            cadastro.Show();
            this.Close();

        }
    }
}
