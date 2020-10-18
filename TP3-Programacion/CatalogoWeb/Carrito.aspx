<%@ Page Title="Carrito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="CatalogoWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="padding-top: 4rem">
        <asp:GridView ID="gvdTabla" runat="server"  AutoGenerateColumns="True" class="table table-sm;" RowStyle-ForeColor="White" RowStyle-CssClass="bg-dark" HeaderStyle-CssClass="bg-dark" HeaderStyle-ForeColor="White"></asp:GridView>
     
        <div style="text-align:center;">
           <p  style="font-size:100px; font-weight:500;  border-color:black; padding-top:20px; border:double;  ">Valor Total:<%=Total %></p>
        </div>

        <div class="row justify-content-between" style="padding-top: 15rem">
            <div class="col-4">
                <a href="Default.aspx" class="btn btn-outline-primary" style="font-size: x-large; height: 50px; width: 225px; text-align: center; display: inline-block">Catalogo</a>
            </div>
            <div class="col-4">
                <asp:Button ID="EliminarArticulos" runat="server" Text="Eliminar Articulos" OnClick="btnVaciarCarrito_Click" class="btn btn-outline-danger" Style="font-size: x-large; height: 50px; width: 225px; text-align: center; display: inline-block" />
            </div>
        </div>
    </div>
</asp:Content>

