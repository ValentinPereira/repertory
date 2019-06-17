using System;
using System.Collections.Generic;
using System.Data;
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

namespace repertory.Views
{
    /// <summary>
    /// Logique d'interaction pour profil.xaml
    /// </summary>
    public partial class profil : Window
    {
        public profil()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int id = Users.IdUserConnected;
            string strConn = "data source=DELL-PC\\SQLEXPRESS;initial catalog=repertory;integrated security=True;multipleactiveresultsets=True; database=repertory; integrated security=SSPI";
            SqlConnection con = new SqlConnection(strConn);
            con.Open();
            string query = "SELECT * FROM [repertory].[dbo].[Users] AS [Users]" +
                           " WHERE [Users].[idUser] = " + id + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                textblockTitle.Text = "Bienvenue " + dataSet.Tables[0].Rows[0]["username"].ToString() + ",";
                textblockFirstname.Text = dataSet.Tables[0].Rows[0]["firstname"].ToString();
                textblockLastname.Text = dataSet.Tables[0].Rows[0]["lastname"].ToString();
                textblockUsername.Text = dataSet.Tables[0].Rows[0]["username"].ToString();
                textblockMail.Text = dataSet.Tables[0].Rows[0]["mail"].ToString();
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite, veuillez réessayer.","Erreur");
            }
            con.Close();
        }

        private void BtnAddContact_Click(object sender, RoutedEventArgs e)
        {
            // Instanciation mon objet windowAddContact de la fênetre AddContact
            AddContact windowAddContact = new AddContact();
            // Affichage de la fênetre Login
            windowAddContact.Show();
            // Fermeture de la fenêtre actuelle
            this.Close();
        }

        private void BtnListContact_Click(object sender, RoutedEventArgs e)
        {
            //Instanciation de l'objet lisContact 
            ListContact listContact = new ListContact();
            //Affichage de la fenêtre
            listContact.Show();
            //Ferme la fenêtre
            this.Close();
        }
    }
}
