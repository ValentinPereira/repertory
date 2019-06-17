using repertory.Model;
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
using System.Windows.Shapes;

namespace repertory.Views
{
    /// <summary>
    /// Logique d'interaction pour AddContact.xaml
    /// </summary>
    public partial class AddContact : Window
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void BtnAddContact_Click(object sender, RoutedEventArgs e)
        {
            //Regex, récupére les données de l'utilisateur.
            string regexName = @"^[A-Za-zéàèêëïîç\- ]+$";
            string regexMail = @"^[A-Z-a-z-0-9-.éàèîÏôöùüûêëç]{2,}@[A-Z-a-z-0-9éèàêâùïüëç]{2,}[.][a-z]{2,6}$";
            int id = Users.IdUserConnected; // Instancie l'objet id de type int à la table Users depuis le champs idUserConnected
            string firstname = textboxLastname.Text;
            string lastname = textboxFirstname.Text;
            string mail = textboxMail.Text;
            string phoneNumber = textboxPhoneNumber.Text;
            string address = textboxAddress.Text;
            bool isValid = true;

            //Vérification des différents champs
            if (!String.IsNullOrEmpty(firstname))
            {
                if (!Regex.IsMatch(firstname, regexName))
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
                TextBlockLastnameErrorMessage.Text = "Le champ est vide";
                isValid = false;
            }
            if (String.IsNullOrEmpty(lastname))
            {
                TextBlockLastnameErrorMessage.Text = "Saisie non valide";
                isValid = false;
            }
            else
            {
                TextBlockMailErrorMessage.Text = "";
            }
            if (String.IsNullOrEmpty(regexMail))
            {
                TextBlockMailErrorMessage.Text = "Saisie non valide";
                isValid = false;
            }
            else
            {
                TextBlockLastnameErrorMessage.Text = "";
            }
            if (String.IsNullOrEmpty(phoneNumber))
            {
                TextBlockPhoneNumberErrorMessage.Text = "Saisie non valide";
                isValid = false;
            }
            else
            {
                TextBlockPhoneNumberErrorMessage.Text = "";
            }
            if (String.IsNullOrEmpty(address))
            {
                TextBlockAddressErrorMessage.Text = "Saisie non valide";
                isValid = false;
            }
            else
            {
                TextBlockAddressErrorMessage.Text = "";
            }
            if (isValid)
            {
                // Execution de la méthode register de la classe contact
                Contact.Register(lastname, firstname, mail, phoneNumber, address,id);
                // Message de validation
                MessageBox.Show("Votre contact est ajout", "Message de confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
                // Remet les champs a zéro
                textboxLastname.Text = null;
                textboxFirstname.Text = null;
                textboxPhoneNumber.Text = null;
                textboxMail.Text = null;
                textboxAddress.Text = null;

            }
        }
    }
}
