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
    public partial class Ejercicio1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cargar provincias al iniciar la página
                CargarProvinciasInicio();
                CargarProvinciasFinal();  // Se cargan todas las provincias inicialmente
            }
        }

        private void CargarProvinciasInicio()
        {
            using (SqlConnection cn = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog = Viajes; Integrated Security = True;"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdProvincia, NombreProvincia FROM Provincias", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                ddlProvinciaInicio.DataSource = dr;
                ddlProvinciaInicio.DataTextField = "NombreProvincia";
                ddlProvinciaInicio.DataValueField = "IdProvincia";
                ddlProvinciaInicio.DataBind();
            }
        }

        private void CargarProvinciasFinal()
        {
            using (SqlConnection cn = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog = Viajes; Integrated Security = True;"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdProvincia, NombreProvincia FROM Provincias", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                ddlProvinciaFinal.DataSource = dr;
                ddlProvinciaFinal.DataTextField = "NombreProvincia";
                ddlProvinciaFinal.DataValueField = "IdProvincia";
                ddlProvinciaFinal.DataBind();
            }
        }

        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar localidades de la provincia seleccionada en ddlProvinciaInicio
            CargarLocalidadesInicio();

            // Recargar provincias finales excluyendo la provincia seleccionada en ddlProvinciaInicio
            CargarProvinciasFinalExcluyendoSeleccionada();
        }

        private void CargarLocalidadesInicio()
        {
            using (SqlConnection cn = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog = Viajes; Integrated Security = True;"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdLocalidad, NombreLocalidad FROM Localidades WHERE IdProvincia = @IdProvincia", cn);
                cmd.Parameters.AddWithValue("@IdProvincia", ddlProvinciaInicio.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();

                ddlLocalidadInicio.DataSource = dr;
                ddlLocalidadInicio.DataTextField = "NombreLocalidad";
                ddlLocalidadInicio.DataValueField = "IdLocalidad";
                ddlLocalidadInicio.DataBind();
            }
        }

        private void CargarProvinciasFinalExcluyendoSeleccionada()
        {
            using (SqlConnection cn = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog = Viajes; Integrated Security = True;"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdProvincia, NombreProvincia FROM Provincias WHERE IdProvincia != @IdProvincia", cn);
                cmd.Parameters.AddWithValue("@IdProvincia", ddlProvinciaInicio.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();

                ddlProvinciaFinal.DataSource = dr;
                ddlProvinciaFinal.DataTextField = "NombreProvincia";
                ddlProvinciaFinal.DataValueField = "IdProvincia";
                ddlProvinciaFinal.DataBind();
            }
        }

        protected void ddlProvinciaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar localidades de la provincia seleccionada en ddlProvinciaFinal
            CargarLocalidadesFinal();
        }

        private void CargarLocalidadesFinal()
        {
            using (SqlConnection cn = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog = Viajes; Integrated Security = True;"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdLocalidad, NombreLocalidad FROM Localidades WHERE IdProvincia = @IdProvincia", cn);
                cmd.Parameters.AddWithValue("@IdProvincia", ddlProvinciaFinal.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();

                ddlLocalidadFinal.DataSource = dr;
                ddlLocalidadFinal.DataTextField = "NombreLocalidad";
                ddlLocalidadFinal.DataValueField = "IdLocalidad";
                ddlLocalidadFinal.DataBind();
            }
        }
    }
}