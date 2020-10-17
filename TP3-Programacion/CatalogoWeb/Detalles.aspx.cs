using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Catologo;
using System.Data;

namespace CatalogoWeb
{
    public partial class Detalles : System.Web.UI.Page
    {
        
        public Articulos lista { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Articulos> Busqueda;
            CatologoArticulo BuscarArticulo = new CatologoArticulo();
            Busqueda = BuscarArticulo.Listar();

            int idAux = Convert.ToInt32(Request.QueryString["idArticulo"]);
            lista = Busqueda.Find(i => i.idArticulo == idAux);

        }

       
        public DataTable CrearTabla()
        {
            
            DataTable td = new DataTable();
            td.Columns.Add("PRODUCTO");
            td.Columns.Add("MARCA");
            td.Columns.Add("PRECIO");
            return td;
        }

        public void AgregarDatosTabla(DataTable tabla, string nomArticulo, string marcaArticulo, float precioArticulo)
        {
            DataRow dr = tabla.NewRow();
            dr["PRODUCTO"] = nomArticulo;
            dr["MARCA"] = marcaArticulo;
            dr["PRECIO"] = precioArticulo;

            float parcial = precioArticulo;
            if(Session["MontoTotal"] == null)
            {
                Session["MontoTotal"] = parcial;
            }
            else 
            {
                float total = (float)(Session["MontoTotal"]);
                Session["MontoTotal"] = parcial + total;
            }

            tabla.Rows.Add(dr);
        }

        public void btnCarrito_Click(object sender, EventArgs e)
        {
            List<Articulos> Busqueda;
            CatologoArticulo BuscarArticulo = new CatologoArticulo();
            Busqueda = BuscarArticulo.Listar();

            int idAux = Convert.ToInt32(Request.QueryString["idArticulo"]);
            lista = Busqueda.Find(i => i.idArticulo == idAux);

            if (Session["Tabla"] == null)
            {
                Session["Tabla"] = CrearTabla();
            }

            AgregarDatosTabla((DataTable)Session["Tabla"], lista.Nombre.ToString(), lista.Marca.ToString(), (float)lista.Precio);
            Response.Redirect("Carrito.aspx");
            
        }

    }
}