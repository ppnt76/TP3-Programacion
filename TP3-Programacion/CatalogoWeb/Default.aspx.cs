﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Catologo;
using Dominio;

namespace CatalogoWeb
{
    public partial class _Default : Page
    {
        public List<Articulos> listaCatalogo { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                CatologoArticulo productos = new CatologoArticulo();
                listaCatalogo = productos.Listar();
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
            
           
        }

        public void txtboxBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> Busqueda;
            CatologoArticulo BuscarArticulo = new CatologoArticulo();
            Busqueda= BuscarArticulo.Listar();

            try
            {
                if (txtFiltro.Text == " ")
                {
                    listaCatalogo = Busqueda;
                }
                else
                {
                    listaCatalogo = Busqueda.FindAll(Y => Y.Nombre.ToLower().Contains(txtFiltro.Text.ToLower()) || Y.Marca.DescripcionMarca.ToLower().Contains(txtFiltro.Text.ToLower()) || Y.categoria.DescripcionCategoria.ToLower().Contains(txtFiltro.Text.ToLower()));
                }
            }
            
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}