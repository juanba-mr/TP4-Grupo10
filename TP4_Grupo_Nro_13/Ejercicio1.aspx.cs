using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace TP4_Grupo_Nro_13
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog = Viajes; Integrated Security = True;");

                cn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Provincias", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                ddlProvinciaInicio.DataSource = dr;

                ddlProvinciaInicio.DataTextField = "NombreProvincia";
                ddlProvinciaInicio.DataValueField = "IdProvincia";

                ddlProvinciaInicio.DataBind();

                dr.Close();


                /*SqlCommand cmdProvFinal = new SqlCommand("Select * from Provincias where IdProvincia !="+ ddlProvinciaInicio.SelectedValue, cn);
                */
                SqlDataReader drprovfinal = cmd.ExecuteReader();
                ddlProvinciaFinal.DataSource = drprovfinal;
                ddlProvinciaFinal.DataTextField = "NombreProvincia";
                ddlProvinciaFinal.DataValueField = "IdProvincia";
                ddlProvinciaFinal.DataBind();
                dr.Close();
                cn.Close();
            }
        }

        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog= Viajes; Integrated Security = True;");

            cn.Open();

            SqlCommand cmdLocalidadInicio = new SqlCommand("Select * from Localidades where IdProvincia = "
            + ddlProvinciaInicio.SelectedValue, cn);

            SqlDataReader drLocalidadInicio = cmdLocalidadInicio.ExecuteReader();

            ddlLocalidadInicio.DataSource = drLocalidadInicio;

            ddlLocalidadInicio.DataTextField = "NombreLocalidad";
            ddlLocalidadInicio.DataValueField = "IdLocalidad";

            ddlLocalidadInicio.DataBind();

            drLocalidadInicio.Close(); // MUESTRA LAS PROVINCIAS MENOS LA SELECCIONADA EN EL DDL ANTERIOR

            SqlCommand cmdProvFinal = new SqlCommand("Select * from Provincias where IdProvincia !=" + ddlProvinciaInicio.SelectedValue, cn);
            SqlDataReader drprovfinal = cmdProvFinal.ExecuteReader();
            ddlProvinciaFinal.DataSource = drprovfinal;
            ddlProvinciaFinal.DataTextField = "NombreProvincia";
            ddlProvinciaFinal.DataValueField = "IdProvincia";
            ddlProvinciaFinal.DataBind();
            cn.Close();
        }

        protected void ddlProvinciaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog= Viajes; Integrated Security = True;");

            cn.Open();

            SqlCommand cmdLocalidadFinal = new SqlCommand("Select * from Localidades where IdProvincia = "
            + ddlProvinciaFinal.SelectedValue, cn);

            SqlDataReader drLocalidadFinal = cmdLocalidadFinal.ExecuteReader();

            ddlLocalidadFinal.DataSource = drLocalidadFinal;

            ddlLocalidadFinal.DataTextField = "NombreLocalidad";
            ddlLocalidadFinal.DataValueField = "IdLocalidad";

            ddlLocalidadFinal.DataBind();
            cn.Close();
        }
    }
}