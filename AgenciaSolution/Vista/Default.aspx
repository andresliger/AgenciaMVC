<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Vista._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <div class="col-md-6">
                <h1 class="text-primary">Agencia <small>Traveling Fast</small></h1>
                <p class="lead">Los mejores vuelos, los mejores precios.</p>
            </div>
            <div class="col-md-6">
                
                <img alt="200" src="~/Resources/inicio_traveling.png" /></div>

        </div>

    </div>

    <div class="row">
        <div class="col-md-4">
            <h2 class="text-primary">Consultar Vuelos</h2>

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
