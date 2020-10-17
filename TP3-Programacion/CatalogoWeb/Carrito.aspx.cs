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
    public partial class About : Page
    {   
        public List<Articulos> seleccionado;

        public float Total;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Tabla"] !=null)
            {
                gvdTabla.DataSource = (DataTable)Session["Tabla"];
                gvdTabla.DataBind();

            }
            Total =(float)Session["MontoTotal"];


        }
       
        public void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            Session["Tabla"] = null;
            Session["MontoTotal"] = null;
            //Total = 0;
            gvdTabla.DataSource = (DataTable)Session["Tabla"];
            gvdTabla.DataBind();
            Total = 0;
        }
    }
}