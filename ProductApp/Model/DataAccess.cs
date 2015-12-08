using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductApp.Model
{
    public class DataAccess
    {
        public static SqlConnection DatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProductDBEntities"].ConnectionString;
            SqlConnection connection=new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public bool InsertProducts(Product product)
        {
            SqlConnection connection=DatabaseConnection();
            string query = "Insert Into Product Values ('" + product.BrandName + "','" + product.PCatagory + "','" +
                           product.Details + "','" + product.Price + "','" + product.Stock + "','" + product.NoOfIteam +
                           "','" + product.PType + "')";
            SqlCommand command=new SqlCommand(query,connection);
            
            if (command.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable GetAllProduct()
        {
            SqlConnection connection = DatabaseConnection();
            string query = "Select * From Product";
            SqlDataAdapter adapter= new SqlDataAdapter(query,connection);
            DataTable data=new DataTable();
            adapter.Fill(data);
            return data;
        }
    }
}