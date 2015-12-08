using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductApp.Model;

namespace ProductApp
{
    public partial class WalletAndCartOperation : System.Web.UI.Page
    {
        DataAccess data=new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ProductDBEntities"].ConnectionString;
                SqlConnection connection=new SqlConnection(connectionString);
                string query = "select DISTINCT PCatagory from Product";
                SqlCommand command= new SqlCommand(query,connection);
                connection.Open();
                catagoryDropDownList.DataSource = command.ExecuteReader();
                catagoryDropDownList.DataTextField = "PCatagory";
                catagoryDropDownList.DataValueField = "PCatagory";
                catagoryDropDownList.DataBind();
                connection.Close();
            }

        }

        protected void catagoryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (catagoryDropDownList.SelectedIndex >= 0)
            {
                string pcat = catagoryDropDownList.SelectedItem.Text;

                string connectionString = ConfigurationManager.ConnectionStrings["ProductDBEntities"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "select DISTINCT PType from Product where PCatagory='" + pcat + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                productTypeDropDownList.DataSource = command.ExecuteReader();
                productTypeDropDownList.DataTextField = "PType";
                productTypeDropDownList.DataValueField = "PType";
                productTypeDropDownList.DataBind();
                connection.Close();
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            string pcat = catagoryDropDownList.SelectedItem.Text;
            string ptype = productTypeDropDownList.SelectedItem.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["ProductDBEntities"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from Product where PCatagory='" + pcat + "' AND PType='"+ptype+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            connection.Open();
            DataTable dataTable=new DataTable();
            adapter.Fill(dataTable);
            showGridView.DataSource = dataTable;
            showGridView.DataBind();
        }
    }
}