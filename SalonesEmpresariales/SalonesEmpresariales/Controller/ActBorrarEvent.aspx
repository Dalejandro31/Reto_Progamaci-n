<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPage.Master" AutoEventWireup="true" CodeBehind="ActBorrarEvent.aspx.cs" Inherits="SalonesEmpresariales.Controller.ActBorrarEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">

        <div class="card text-center">
            <div class="card-header">
                Featured
            </div>
            <div class="card-body flex-container">

                <%-- IDENTIFICACION --%>
                <div class="col-md-6" style="padding: 16px;">
                    <asp:Label ID="lblBusqueda" runat="server" Text="Identificacion: "></asp:Label>
                    <asp:TextBox ID="txt_ActBusDocCliente" class="form-control" runat="server" placeholder="Cedula"></asp:TextBox>


                </div>
                <%-- FECHA --%>
                <div class="col-md-6" style="padding: 16px;">

                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Fecha: "></asp:Label>
                    <asp:TextBox ID="txtFecha" TextMode="Date" class="form-control" runat="server" placeholder=""></asp:TextBox>


                </div>



                <div>
                    <br />
                    <asp:Button ID="btnBusActDOC" runat="server" class="btn btn-primary" Text="Busqueda" OnClick="btnBusActDOC_Click" />

                </div>

                <div id="VisualizarNombre2" runat="server" visible="false">
                    <%-- Nombre--%>
                    <div class="col-md-6" style="padding: 16px;">
                        <asp:Label ID="lblvisualizarNombre2" runat="server" Text="Nombre: "></asp:Label>
                        <asp:Label ID="lblNombreVisual2" class="form-control" runat="server"></asp:Label>

                    </div>
                </div>


                <div id="VisualizarApellido2" runat="server" visible="false">
                    <%-- Apellido--%>
                    <div class="col-md-6" style="padding: 16px;">
                        <asp:Label ID="lblVisualApellido2" runat="server" Text="Apellido: "></asp:Label>
                        <asp:Label ID="lblApelliVisual2" class="form-control" runat="server"></asp:Label>

                    </div>
                </div>


                <div id="VisualizarTelefono2" runat="server" visible="false">
                    <%-- Telefono--%>
                    <div class="col-md-6" style="padding: 16px;">
                        <asp:Label ID="lblVisualizarTelefono2" runat="server" Text="Telefono: "></asp:Label>
                        <asp:Label ID="lblTelefonoVisual2" class="form-control" runat="server"></asp:Label>

                    </div>
                </div>


                <%-- ///////////////////////////////////////////////////////////////// --%>
                <%-- ///////////////////////**********************/////////////////// --%>

                <%-- IdEvento --%>

                <div id="DivIdEvento2" runat="server" visible="false">
                    <div class="col-md-6" style="padding: 16px;">
                        <asp:Label ID="IdEvento2" runat="server" Text=""></asp:Label>

                    </div>
                </div>


                <%-- fecha --%>

                <div id="AgentarEventoVisual2" runat="server" visible="false">
                    <div class="col-md-6" style="padding: 16px;">

                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Fecha: "></asp:Label>
                        <asp:TextBox ID="txtFecha2" TextMode="Date" class="form-control" runat="server" placeholder=""></asp:TextBox>
                        <asp:Label ID="lblFechaValidacion" runat="server" Text=""></asp:Label>

                    </div>


                    <%-- Cantidad personas --%>
                    <div class="col-md-6" style="padding: 16px;">
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Cantidad Personas "></asp:Label>
                        <asp:TextBox ID="txtCantidad2" class="form-control" runat="server" placeholder="Cantidad asistentes"></asp:TextBox>
                        <asp:Label ID="lblcantidadValidacion" runat="server" Text=""></asp:Label>

                    </div>


                    <%--<%--MOTIVO--%>

                    <div class="col-md-6" style="padding: 16px;">
                        <asp:Label ID="Label7" runat="server" Text="Motivo"></asp:Label><br />
                        <asp:DropDownList ID="DDLmotivo2" Style="width: 200px; height: 50px" class="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DDLmotivo2_SelectedIndexChanged"></asp:DropDownList>
                        <asp:Label ID="lblMotivoValidar" runat="server" Text=""></asp:Label>
                    </div>

                    <%-- observaciones --%>
                    <div class="col-md-6" style="padding: 16px;">
                        <asp:Label ID="Label3" runat="server" Text="Observaciones "></asp:Label>
                        <asp:TextBox ID="txt_observacione2s" class="form-control" runat="server" placeholder="Observaciones" TextMode="MultiLine"></asp:TextBox>
                        <asp:Label ID="lblObservacionesValidar" runat="server" Text=""></asp:Label>
                    </div>

                    <%-- ESTADO--%>

                    <div class="col-md-6" style="padding: 16px;">

                        <asp:Label ID="Label8" runat="server" Text="Estado "></asp:Label><br />
                        <asp:DropDownList ID="DDLestado2" Style="width: 200px; height: 50px" class="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DDLestado2_SelectedIndexChanged"></asp:DropDownList>
                        <asp:Label ID="lblEstadoValidar" runat="server" Text=""></asp:Label>
                    </div>


                    <div>
                        <br />

                        <asp:Button ID="BtnActualizarEvento1" runat="server" class="btn btn-primary" Text="Actualizar Evento" OnClick="BtnActualizarEvento1_Click" />
                        <asp:Button ID="BtnBorrarEvento1" runat="server" class="btn btn-primary" Text="Borrar Evento" OnClick="BtnBorrarEvento1_Click" />
                    </div>

                    <div class="card-footer text-muted">
                        2 days ago
                    </div>
                </div>
            </div>
        </div>
    </form>



    </body>


</asp:Content>
