using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductApp.Model;

namespace ProductApp
{
    public partial class InsertProduct : System.Web.UI.Page
    {
        DataAccess data=new DataAccess();
        Product product=new Product();
        protected void Page_Load(object sender, EventArgs e)
        {
            productGridView.DataSource=data.GetAllProduct();
            productGridView.DataBind();
        }
        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            product.BrandName = txtBrandName.Text;
            product.PCatagory = txtCatagory.Text;
            product.Details = txtDetails.Text;
            product.Price = Convert.ToDecimal(txtPrice.Text);
            product.Stock = Convert.ToInt32(txtStock.Text);
            product.NoOfIteam = Convert.ToInt32(txtNoOfIteam.Text);
            product.PType = txtProductType.Text;

            if (data.InsertProducts(product))
            {
                lblMsg.Text = "Insert Succesfully";
                ClearTextbox();
                productGridView.DataSource= data.GetAllProduct();
                productGridView.DataBind();
            }
            else
            {
                lblMsg.Text = "Sorry!!!!!!";
            }
        }

        private void ClearTextbox()
        {
            txtBrandName.Text = string.Empty;
            txtCatagory.Text = string.Empty;
            txtDetails.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtNoOfIteam.Text = string.Empty;
            txtProductType.Text = string.Empty;
        }
    }
}