using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace repertory.Helper_code
{
    class sqlConnect
    {
        public static List<string> ExecuteQueryList(string query)
        {
            // Initialisation. 
            List<string> thisUser = new List<string>();
            SqlDataReader result = null;
            string strConn = "data source=DELL-PC\\SQLEXPRESS;initial catalog=repertory;integrated security=True;multipleactiveresultsets=True; database=repertory; integrated security=SSPI";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            SqlCommand sqlCommand = new SqlCommand();
            try
            {
                // Parametres.  
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandTimeout = 12 * 3600;
                // Open la connexion.   
                sqlConnection.Open();
                // on stock le résultat de l'execution. .  
                result = sqlCommand.ExecuteReader();
                while (result.Read())
                {
                    var myString = result.GetString(0);
                    thisUser.Add(myString);
                } 
                // Ferme la connexion..  
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                // Ferme la connexion..  
                sqlConnection.Close();
                throw ex;
            }
            // Retourne la variable string result
            return thisUser;
        }
        public static string ExecuteQueryString(string query)
        {
            // Initialisation. 
            object result = null;
            string resultString = null;
            string strConn = "data source=DELL-PC\\SQLEXPRESS;initial catalog=repertory;integrated security=True;multipleactiveresultsets=True; database=repertory; integrated security=SSPI";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            SqlCommand sqlCommand = new SqlCommand();
            try
            {
                // Parametres.  
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandTimeout = 12 * 3600;
                // Open la connexion.   
                sqlConnection.Open();
                // on stock le résultat de l'execution. .  
                result = sqlCommand.ExecuteScalar();
                if(result != null)
                {
                    resultString = result.ToString();
                }
                // Ferme la connexion..
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                // Ferme la connexion..  
                sqlConnection.Close();
                throw ex;
            }
            // Retourne la variable string result
            return resultString;
        }
        public static int ExecuteQuery(string query)
        {
            // Initialisation.  
            int rowCount = 0;
            string strConn = "data source=DELL-PC\\SQLEXPRESS;initial catalog=repertory;integrated security=True;multipleactiveresultsets=True; database=repertory; integrated security=SSPI";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            SqlCommand sqlCommand = new SqlCommand();
            try
            {
                // Parametres.  
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandTimeout = 12 * 3600;

                // Open connexion. 
                sqlConnection.Open();

                // on stock le résultat de l'execution. .  
                rowCount = sqlCommand.ExecuteNonQuery();

                // Ferme la connexion..  
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                // Ferme la connexion..  
                sqlConnection.Close();

                throw ex;
            }
            // Retourne la variable int rowCount
            return rowCount;
        }
    }
}
