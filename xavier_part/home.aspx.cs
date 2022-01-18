using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
namespace xavier_part
{
    public partial class home : System.Web.UI.Page
    {
        Product prod = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataList1.RepeatColumns = 5;
            DataList1.RepeatDirection = RepeatDirection.Horizontal;
        }

        protected void DataList1_view(object source, DataListCommandEventArgs e)
        {
            Response.Redirect("product_desc.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

      
        
    }
}