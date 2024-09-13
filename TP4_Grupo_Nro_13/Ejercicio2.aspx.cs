using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Grupo_Nro_13
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True;");

                cn.Open();

                SqlCommand cmd = new SqlCommand("SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                grdDatos.DataSource = dr;
                grdDatos.DataBind();
                cn.Close();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True;");

            cn.Open();

            

            if (ddlProducto.SelectedValue == "==")
            {

                SqlCommand cmd = new SqlCommand("SELECT IdProducto, NombreProducto, IdCategoría," +
                " CantidadPorUnidad, PrecioUnidad FROM Productos WHERE  IdProducto =" + txtIDProducto.Text, cn);

                SqlDataReader dr = cmd.ExecuteReader();
                grdDatos.DataSource = dr;
                grdDatos.DataBind();

            }
            cn.Close();
            txtIDProducto.Text = "";
            txtIDCategoria.Text = "";
        }
    }
}