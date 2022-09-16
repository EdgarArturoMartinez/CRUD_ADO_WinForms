using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WinForms_ADO_CRUD
{
    public class PeopleDB
    {
        private string connectionString
            = "Data Source=YUXMED0040L;Initial Catalog=TestDB; " +
            "User=admin; Password=admin" ;

        public bool GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();  
            }
            catch 
            {

                return false;
            }
            return true;
        }

        public List<People> GetPeople()
        {
            List<People> people = new List<People>();

            string query = "SELECT * FROM People";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection); 
            }

                return people;
        }
    }

    
}
