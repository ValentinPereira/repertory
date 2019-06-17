using repertory.Model;
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


namespace repertory.Views
{
    /// <summary>
    /// Logique d'interaction pour ListContact.xaml
    /// </summary>
    public partial class ListContact : Window
    {
        public ListContact()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Connecte la base de données
            string strConn = "data source=DELL-PC\\SQLEXPRESS;initial catalog=repertory;integrated security=True;multipleactiveresultsets=True; database=repertory; integrated security=SSPI";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            try
            {
                // ouvre la connection
                sqlConnection.Open();
                // Selectionne les colonnes de la tables "contacts" object query, type string
                string query = "SELECT [lastname], [firstname], [mail], [phoneNumber], [address] FROM [contacts]";
                // Instancie mon objet listContact et recupere la commande puis connection 
                SqlCommand listContact = new SqlCommand(query, sqlConnection);
                listContact.ExecuteNonQuery(); // Execute la connection

                SqlDataAdapter dataAdp = new SqlDataAdapter(listContact);
                DataTable dt = new DataTable("contacts");
                dataAdp.Fill(dt);
                listContactDataGrid.ItemsSource = dt.DefaultView;
                dataAdp.Update(dt);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
