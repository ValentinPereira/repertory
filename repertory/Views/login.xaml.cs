using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using repertory.Model;
using repertory.Helper_code;
using repertory.Views;

namespace repertory
{
    /// <summary>
    /// Logique d'interaction pour login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Méthode de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Déclaration et attribution des variables
            string password = passwordboxLoginPassword.Password.ToString();
            string mail = textboxLoginMail.Text;
            // Execution de la requete afin de récuperer id de utilisateur si il existe
            string login = Users.Login(mail, password);
            // Si requete ne renvoie pas null ou rien
            if (!String.IsNullOrEmpty(login))
            {
                // On stock le login dans une attribut de la classe Users
                Users.IdUserConnected = int.Parse(login);
                textblockErrorLogin.Text = "Identifiants réussi";
                // Instanciation  de la fênetre profil
                profil profilWindow = new profil();
                // Affichage de la fênetre profil
                profilWindow.Show();
                // Fermeture de la fênetre actuelle
                this.Close();
            }
            else
            {
                textblockErrorLogin.Text = "Identifiants incorrect";
            }
        }
        /// <summary>
        /// Méthode pour le lien hyperlink afin de retourne vers le mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            // Instanciation  de la fênetre MainWindow
            MainWindow mainWindow = new MainWindow();
            // Affichage de la fênetre MainWindow
            mainWindow.Show();
            // Fermeture de la fênetre actuelle
            this.Close();
        }
    }
}
