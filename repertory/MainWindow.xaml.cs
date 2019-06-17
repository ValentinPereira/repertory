using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using repertory.Helper_code;
using repertory.Model;

namespace repertory
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnexion_Click(object sender, RoutedEventArgs e)
        {
            // Instanciation mon objet windowLogin de la fênetre Login
            Login windowLogin = new Login();
            // Affichage de la fênetre Login
            windowLogin.Show();
            // Fermeture de la fênetre actuelle
            this.Close();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            // Déclaration des variables contenant les regexs et information de l'utilisateur de la textbox
            string regexName = @"^[A-Za-zéàèêëïîç\- ]+$";
            string regexMail = @"^[A-Z-a-z-0-9-.éàèîÏôöùüûêëç]{2,}@[A-Z-a-z-0-9éèàêâùïüëç]{2,}[.][a-z]{2,6}$";
            string firstname = textboxLastname.Text;
            string lastname = textboxFirstname.Text;
            string username = textboxUsername.Text;
            string mail = textboxMail.Text;
            string password = passboxPassword.Password.ToString();
            string passwordC = passboxPasswordC.Password.ToString();
            bool isValid = true;
            // Vérification des différents champs de l'utilisateur
            if (!String.IsNullOrEmpty(firstname))
            {
                if (!Regex.IsMatch(firstname, regexName))
                {
                    TextBlockLastnameErrorMessage.Text = "Saisie non valide";
                    isValid = false;
                }
                else
                {
                    TextBlockLastnameErrorMessage.Text = "";
                }
            }
            else
            {
                TextBlockLastnameErrorMessage.Text = "Le champ est vide";
                isValid = false;
            }
            if (!String.IsNullOrEmpty(lastname))
            {
                if (!Regex.IsMatch(lastname, regexName))
                {
                    TextBlockFirstnameErrorMessage.Text = "Saisie non valide";
                    isValid = false;
                }
                else
                {
                    TextBlockFirstnameErrorMessage.Text = "";
                }
            }
            else
            {
                TextBlockFirstnameErrorMessage.Text = "Le champ est vide";
                isValid = false;
            }
            if (!String.IsNullOrEmpty(username))
            {
                if (!Regex.IsMatch(username, regexName))
                {
                    TextBlockUsernameErrorMessage.Text = "Saisie non valide";
                    isValid = false;
                }
                else
                {
                    TextBlockUsernameErrorMessage.Text = "";
                }
            }
            else
            {
                TextBlockUsernameErrorMessage.Text = "Le champ est vide";
                isValid = false;
            }
            if (!String.IsNullOrEmpty(mail))
            {
                if (!Regex.IsMatch(mail, regexMail))
                {
                    TextBlockMailErrorMessage.Text = "Saisie non valide";
                    isValid = false;
                }
                else
                {
                    if (!String.IsNullOrEmpty(Users.VerifMail(mail)))
                    {
                        TextBlockMailErrorMessage.Text = mail + " ce mail existe déjà";
                        // Remet les champs à zéro
                        passboxPassword.Password = null;
                        passboxPasswordC.Password = null;
                        isValid = false;
                    }
                    else
                    {
                        TextBlockMailErrorMessage.Text = "";
                    }
                    
                }
            }
            else
            {
                TextBlockMailErrorMessage.Text = "Le champ est vide";
                isValid = false;
            }
            // Vérification du mot de passe 
            if (!String.IsNullOrEmpty(password)) // Si le mot de passe n'est pas null ou vide
            {
                if (!String.IsNullOrEmpty(passwordC)) // Si la confirmation n'est pas null ou vide
                {
                    if (Regex.IsMatch(password, regexName)) // Si le mot de passe match avec la regex
                    {
                        if (password != passwordC) // Si le mot de passe ne correspond pas a la confirmation
                        {
                            TextBlockPasswordCErrorMessage.Text = "La confirmation ne correspond pas avec le mot de passe ci-dessus";
                            isValid = false;
                        }
                    }
                    else
                    {
                        TextBlockPasswordErrorMessage.Text = "Saisie non valide";
                        isValid = false;
                    }
                }
                else
                {
                    TextBlockPasswordCErrorMessage.Text = "Le champ est vide";
                    isValid = false;
                }
            }
            else
            {
                TextBlockPasswordErrorMessage.Text = "Le champ est vide";
                isValid = false;
            }
            if (isValid)
            {
                // Execution de la méthode register 
                Users.Register(lastname, firstname, username, mail, password);
                // Message de validation
                MessageBox.Show("Votre inscription est validée","Message de confirmation",MessageBoxButton.OK,MessageBoxImage.Information);
                // Remet les champs a zéro
                textboxLastname.Text = null;
                textboxFirstname.Text = null;
                textboxUsername.Text = null;
                textboxMail.Text = null;
                passboxPassword.Password = null;
                passboxPasswordC.Password = null;
            }
        }
    }
}
