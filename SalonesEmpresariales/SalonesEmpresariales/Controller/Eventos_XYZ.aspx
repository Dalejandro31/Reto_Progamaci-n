<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPage.Master" AutoEventWireup="true" CodeBehind="Eventos_XYZ.aspx.cs" Inherits="SalonesEmpresariales.Controller.Eventos_XYZ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>

        <form id="form1" runat="server">

            <div class="card text-center">
                <div class="card-header">
                    Featured
                </div>
                <div class="card-body flex-container">

                    <%-- IDENTIFICACION --%>
                    <div class="col-md-6" style="padding: 16px;">
                        <asp:Label ID="lblBusqueda" runat="server" Text="Identificacion: "></asp:Label>
                        <asp:TextBox ID="txt_BusquedaDocCliente" class="form-control" runat="server" placeholder="Cedula"></asp:TextBox>
                        

                    </div>

                    <div>
                        <br />
                        <asp:Button ID="btnBuscarDoc" runat="server" class="btn btn-primary" Text="Busqueda" OnClick="btnBuscarDoc_Click" />

                    </div>

                    <div id="VisualizarNombre" runat="server" visible="false">
                        <%-- Nombre--%>
                        <div class="col-md-6" style="padding: 16px;">
                            <asp:Label ID="lblvisualizarNombre" runat="server" Text="Nombre: "></asp:Label>
                            <asp:TextBox ID="txtNombreVisual" class="form-control" runat="server"></asp:TextBox>

                        </div>
                    </div>


                    <div id="VisualizarApellido" runat="server" visible="false">
                        <%-- Apellido--%>
                        <div class="col-md-6" style="padding: 16px;">
                            <asp:Label ID="lblVisualApellido" runat="server" Text="Apellido: "></asp:Label>
                            <asp:TextBox ID="txtApelliVisual" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>


                    <div id="VisualizarTelefono" runat="server" visible="false">
                        <%-- Telefono--%>
                        <div class="col-md-6" style="padding: 16px;">
                            <asp:Label ID="lblVisualizarTelefono" runat="server" Text="Telefono: "></asp:Label>
                            <asp:TextBox ID="txtTelefonoVisual" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>


                    <%-- ///////////////////////////////////////////////////////////////// --%>
                    <%-- ///////////////////////**********************/////////////////// --%>

                    <%-- IdEvento --%>

                    <div id="DivIdEvento" runat="server" visible="false">
                        <div class="col-md-6" style="padding: 16px;">
                            <asp:Label ID="IdEvento" runat="server" Text=""></asp:Label>
                        </div>
                    </div>


                    <%-- fecha --%>

                    <div id="AgentarEventoVisual" runat="server" visible="false">
                        <div class="col-md-6" style="padding: 16px;">

                            <br />
                            <asp:Label ID="Label1" runat="server" Text="Fecha: "></asp:Label>
                            <asp:TextBox ID="txtFecha" TextMode="Date" class="form-control" runat="server" placeholder=""></asp:TextBox>
                            <asp:Label ID="lblValidacionFecha" runat="server" Text=""></asp:Label>


                        </div>


                        <%-- Cantidad personas --%>
                        <div class="col-md-6" style="padding: 16px;">
                            <br />
                            <asp:Label ID="Label2" runat="server" Text="Cantidad Personas "></asp:Label>
                            <asp:TextBox ID="txtCantidad" class="form-control" runat="server" placeholder="Cantidad asistentes"></asp:TextBox>
                            <asp:Label ID="lblValidacionCantidad" Visible ="false" runat="server" Text=""></asp:Label>
                        </div>


                        <%--MOTIVO--%>

                        <div class="col-md-6" style="padding: 16px;">
                            <asp:Label ID="Label7" runat="server" Text="Motivo"></asp:Label><br />
                            <asp:DropDownList ID="DDLmotivo" Style="width: 200px; height: 50px" class="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DDLmotivo_SelectedIndexChanged"></asp:DropDownList>
                            <asp:Label ID="lblValidacionMotivo" runat="server" Text=""></asp:Label>
                        </div>

                        <%-- observaciones --%>
                        <div class="col-md-6" style="padding: 16px;">
                            <asp:Label ID="Label3" runat="server" Text="Observaciones "></asp:Label>
                            <asp:TextBox ID="txt_observaciones" class="form-control" runat="server" placeholder="Observaciones" TextMode="MultiLine"></asp:TextBox>
                            <asp:Label ID="lblValidacionObservaciones" runat="server" Text=""></asp:Label>
                        </div>

                        <%-- ESTADO--%>

                        <div class="col-md-6" style="padding: 16px;">

                            <asp:Label ID="Label8" runat="server" Text="Estado "></asp:Label><br />
                            <asp:DropDownList ID="DDLestado" Style="width: 200px; height: 50px" class="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DDLestado_SelectedIndexChanged"></asp:DropDownList>
                            <asp:Label ID="lblValidacionEstado" runat="server" Text=""></asp:Label>
                        </div>

                        <div>
                            <br />
                            <asp:Button ID="BtnCrearEvento" runat="server" class="btn btn-primary" Text="Crear Evento" OnClick="BtnCrearEvento_Click" />
                           
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
