using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using repertory.Helper_code;

namespace repertory.Model
{
    class Contact
    {
        public static void Register(string lastname, string firstname, string mail, string phoneNumber, string address, int idUser)
        {
            try
            {
                // Requete sql .  
                string query = "INSERT INTO[dbo].[Contacts]([lastname],[firstname],[mail],[phoneNumber],[address],[idUser])" +
                                "VALUES('" + lastname + "','" + firstname + "','" + mail + "','" + phoneNumber + "','" + address + "'," + idUser + ")";

                // Execution de la requete SQL.  
                sqlConnect.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

