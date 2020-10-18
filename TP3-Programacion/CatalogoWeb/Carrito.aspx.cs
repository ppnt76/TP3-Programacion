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

        public float Total=0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Tabla"] != null)
                {
                    gvdTabla.DataSource = (DataTable)Session["Tabla"];
                    gvdTabla.DataBind();
                    Total = (float)Session["MontoTotal"];
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
       
        public void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                Session["Tabla"] = null;
                Session["MontoTotal"] = null;
                //Total = 0;
                gvdTabla.DataSource = (DataTable)Session["Tabla"];
                gvdTabla.DataBind();
                Total = 0;
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
    }
}