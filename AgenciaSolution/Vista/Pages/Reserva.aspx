<%@ Page Title="Reserva" Language="C#" MasterPageFile="~/cliente.Master" AutoEventWireup="true" CodeBehind="Reserva.aspx.cs" Inherits="Vista.Pages.Reserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table runat="server">
        <tr>
            <td>
                <h2>Separa tu Boleto</h2>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Ciudad Origen"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlGender" runat="server" Width="200px">
                    <asp:ListItem Text="Select Gender" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Mix" Value="3"></asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Ciudad Destino"></asp:Label>
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
                    <asp:ListItem Text="Select Gender" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                </asp:DropDownList>

                <br />
                <br />
                <table runat="server">
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Fecha Salida"></asp:Label>
                            <div>
                                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>

                            </div>
                        </td>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Fecha Llegada"></asp:Label>
                            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
                        </td>
                    </tr>
                </table>

                <div>
                    <asp:Button ID="Button1" runat="server" Text="Consultar" OnClick="btnSubmit_Click" />
                </div>
            </td>
            
            <td style="padding-left: 40px">
                hola soy el otro derecha
            </td>
        </tr>
    </table>

</asp:Content>
