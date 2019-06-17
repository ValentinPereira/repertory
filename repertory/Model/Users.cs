using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using repertory.Helper_code;
using System.Data.SqlClient;

namespace repertory.Model
{
    public class Users
    {
        public static int IdUserConnected;

        public static void Register(string lastname, string firstname, string username, string mail, string password)
        {
            try
            {
                // Requete sql .  
                string query = "INSERT INTO [dbo].[Users]([lastname],[firstname],[username],[mail],[password])" +
                                "VALUES('" + lastname + "','" + firstname + "','" + username  + "','" + mail + "','" + password  + "')";

                // Execution de la requete SQL.  
                sqlConnect.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string VerifMail(string mail)
        {
            // Déclaration de la variable mailR en NULL
            string mailR = null;
            // Rêquete SQL
            string query = "SELECT [mail] FROM [repertory].[dbo].[Users] AS [Users]" +
                    " WHERE [Users].[mail] = '" + mail +"'";
            // On stock le résultat de la rêquete dans la variable mailR
            mailR = sqlConnect.ExecuteQueryString(query);
            // Retourne la variable mailR
            return mailR;
        }
        public static string Login(string mail,string password)
        {
            // Rêquete SQL
            string query = "SELECT [idUser] FROM [repertory].[dbo].[Users] AS [Users]" +
                    " WHERE [Users].[mail] = '" + mail + "' AND [Users].[password] = '" + password +"'";
            // On stock le résultat de la rêquete dans la variable login
            string login = sqlConnect.ExecuteQueryString(query);
            // Retourne la variable login
            return login;
        }
        public static List<string> ThisUser(int id)
        {
            List<string> thisUser;
            // Rêquete SQL
            string query = "SELECT [lastname],[firstname],[username],[mail],[password] FROM [repertory].[dbo].[Users] AS [Users]" +
                    " WHERE [Users].[idUser] = "+id+"";
            // On stock le résultat de la rêquete dans la variable login
            thisUser = sqlConnect.ExecuteQueryList(query);
            // Retourne la variable login
            return thisUser;
        }
    }
}
