using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PayPal.Api;
namespace xavier_part
{
    public partial class checkoutoverview : System.Web.UI.Page
    {
        SqlConnection knn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\REALLLLLLLLLLLLLLLLLLLLLLL\xavier_part\xavier_part\App_Data\product.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            decimal discountedtotal;
            decimal grandtotal;
            knn.Open();
            SqlCommand cmd = knn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select grandtotal,discountedtotal,orderid,deliveryoption,deliverydate from orderdetails where orderid=@orderid";
            cmd.Parameters.AddWithValue("@orderid", Request.QueryString["orderid"].ToString());
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                if (row.Field<decimal>("discountedtotal").ToString() == "0.00")
                {
                    Labelgg.Text = "Grand Total:$ "+row.Field<decimal>("grandtotal").ToString();
                    Labelorderii.Text = row.Field<string>("orderid").ToString();
                    lbldelop.Text= "Delivery Option: " + row.Field<string>("deliveryoption").ToString();
                    lbldeldate.Text = "Delivery Date: "+row.Field<DateTime>("deliverydate").ToString();
                    break;

                }
                if (row.Field<decimal>("discountedtotal") > Convert.ToDecimal(0.00))
                {
                    Labelorderii.Text = row.Field<string>("orderid").ToString();
                    Labelgg.Text = "Grand Total:$ " + row.Field<decimal>("grandtotal").ToString();
                    Labeldisc.Text = "Discount Total:$ " + row.Field<decimal>("discountedtotal").ToString();
                    lbldelop.Text = "Delivery Option: "+row.Field<string>("deliveryoption").ToString();
                    lbldeldate.Text = "Delivery Date: "+row.Field<DateTime>("deliverydate").ToString();
                    break;
                }

            }

            knn.Close();

            
        }

        protected void btn_proceed_Click(object sender, EventArgs e)
        {
            Response.Redirect("payment.aspx");
        }
    }
}