<%@ Page Title="Detalles" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="CatalogoWeb.Detalles" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col" style="padding-top: 2em;">
                <img src="<%= lista.Imagen %>" alt="SIN IMAGEN" style="border: medium; width: 290px; background-color: lavenderblush" />
            </div>
            <div class="col" style="padding-top: 5em;">
                <p style="font-size: 2rem; text-align: center;"><b>Nombre Articulo: </b><%=lista.Nombre %></p>
                <p style="font-size: 2rem; text-align: center;"><b>Marca: </b><%=lista.Marca.DescripcionMarca %></p>
                <p style="font-size: 2rem; text-align: center;"><b>Categoria: </b><%=lista.categoria.DescripcionCategoria %></p>
                <p style="font-size: 2rem; text-align: center;"><b>Precio: </b><%=lista.Precio %></p>
            </div>
        </div>
        <div class="row justify-content-between" style="padding:3em;">
            <div class="col-4">
                <a href="Default.aspx" class="btn btn-outline-primary" style="font-size: x-large; height: 50px; width: 225px; text-align: center; display: inline-block">Catalogo</a>
            </div>
            <div class="col-4">
               <%--  <a href="Carrito.aspx?idArticulo=<% =lista.idArticulo.ToString() %>"" class="btn btn-outline-success" ID="btnComprar" OnClick="btnComprar_Click" style="font-size: x-large; height: 50px; width: 225px; text-align: center; display: inline-block">Comprar</a> --%>
                <asp:Button ID="Comprar" runat="server" Text="Agregar Al Carrito" OnClick="btnCarrito_Click" class="btn btn-outline-danger" style="font-size: x-large; height: 50px; width: 225px; text-align: center; display: inline-block" />
           </div>
        </div>
    </div>

</asp:Content>
