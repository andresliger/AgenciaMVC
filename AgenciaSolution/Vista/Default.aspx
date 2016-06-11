<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Vista._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Agencia de Vuelos</h1>
        <p class="lead">Dinos lo que necesitas, buscaremos los mejores precios para ti.</p>

        

            <div>

                <asp:Label ID="lblUsername" runat="server" Text="Usuario"></asp:Label>

                &nbsp;&nbsp;&nbsp;&nbsp;

                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblPassword" runat="server" Text="Contraseña"></asp:Label>
                &nbsp
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
        <br />
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Inicio Sesión &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Recepción Vuelos</h2>
            <p>
                Pordrá realizar la reserva de vuelos, dependiendo de su disponibilidad de tiempo.
            </p>
            <p>
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Recepción Fechas</h2>
            <p>
                Puede separar sus vuelos mediante fechas.
            </p>
            <p>
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Nuestros Clientes</h2>
            <p>
                Usted puede ingresar y buscar facilmente clientes.
            </p>
            <p>
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
