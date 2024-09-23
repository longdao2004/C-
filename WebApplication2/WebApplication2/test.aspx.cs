using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace WebApplication2
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string constring = WebConfigurationManager.ConnectionStrings["testcsdl"].ConnectionString;
            //string constring = "Data Source=long\\LONG9NGON;Initial Catalog=vd2;Integrated Security=True";
            SqlConnection myCon = new SqlConnection(constring);
            myCon.Open();
            string str = "";
            SqlCommand cmd = new SqlCommand(str, myCon);
            SqlDataReader data = cmd.ExecuteReader();
        }
    }
}