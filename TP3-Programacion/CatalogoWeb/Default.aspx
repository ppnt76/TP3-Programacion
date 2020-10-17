<%@ Page Title="Catalogo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatalogoWeb._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
    <h1 style="font-size: 3.5rem; text-align:center; font-family:'Courier New'"> <b><strong>PRODUCTOS</strong></b></h1>
    <div style="margin-left:-1300px; margin-top:50px; text-align:center;" >
       <asp:Button ID="Buscar" runat="server" Text="BUSCAR" Height="40px" Width="200px" BorderColor="DarkGreen"  BackColor="LightBlue"/>
           <asp:TextBox ID="txtFiltro" runat="server" OnTextChanged="txtboxBusqueda_TextChanged" AutoPostBack="true"  Height="40px" Width="1000px" BorderColor="Black"></asp:TextBox>         
    </div>
    <div class="container" style="margin-top:100px;">
        <div class="row">
            <div class="card-columns">   
                 <%foreach (Dominio.Articulos item in listaCatalogo)
                     {%>

                    <div class="card-body">
                       <div class="card text-center"" style="border-color:black; height:530px; width:300px">
                           <img src="<%=item.Imagen %>" class="card-img-top" alt="..."  style="width:290px"/>
                           <div class="card-footer" >
                              <p class="card-title" style="font-size:1.5rem"><%=item.Nombre %></p>
                              <p class="card-title" style="font-size:2rem"><b><%=item.Precio %></b></p>
                              <a href="Detalles.aspx?idArticulo=<% =item.idArticulo.ToString() %>" class="btn btn-dark"  style="font-size:x-large; background-color:brown; height:50px; width:225px; text-align:center;">Detalles</a>
                           </div>
                        </div>
                    </div>
                                                            
                 <% }%>
            </div>
        </div>
    </div>   
</asp:Content>

