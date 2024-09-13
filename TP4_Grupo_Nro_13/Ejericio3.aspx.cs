using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Grupo_Nro_13
{
    public partial class Ejericio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True;");

                cn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Temas", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                ddlTemas.DataSource = dr;

                ddlTemas.DataTextField = "Tema";
                ddlTemas.DataValueField = "IdTema";

                ddlTemas.DataBind();

                dr.Close();
            }
        }
    }
}