<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPage.Master" AutoEventWireup="true" CodeBehind="busqueda_Cliente.aspx.cs" Inherits="SalonesEmpresariales.Controller.busqueda_Cliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
        <form id="form1" runat="server">

            <div class="card text-center">
                <div class="card-header r">
                    Busqueda de Cliente
                </div>
                <div class="card-body flex-container ">

                    <%-- IDENTIFICACION --%>
                    <div class="col-md-6" style="padding: 16px;">
                        <asp:Label ID="lblBusqueda" runat="server" Text="Identificacion: "></asp:Label>
                        <asp:TextBox ID="txt_BusquedaIdentificacion" class="form-control" runat="server" placeholder="Cedula"></asp:TextBox>
                        

                    </div>

                    <div>
                        <br />
                        <asp:Button ID="btnBuscar" runat="server" class="btn btn-primary" Text="Busqueda" OnClick="btnBuscar_Click" />

                    </div>

                    <div id="ActualizarDatosCLi" runat="server" visible="false">
                        <%-- Nombre--%>
                        <div class="col-md-6" style="padding: 16px;">
                            <asp:Label ID="lblNombreBusqueda" runat="server" Text="Nombre: "></asp:Label>
                            <asp:TextBox ID="txtNombreBusqueda" class="form-control" runat="server"></asp:TextBox>
                             <asp:Label ID="lblValidacionAct1" runat="server" Text=""></asp:Label>
                        </div>
                    </div>


                    <div id="ActualizarApellido" runat="server" visible="false">
                        <%-- Apellido--%>
                        <div class="col-md-6" style="padding: 16px;">
                            <asp:Label ID="lblApellidoBusqueda" runat="server" Text="Apellido: "></asp:Label>
                            <asp:TextBox ID="txtApellidoBusqueda" class="form-control" runat="server"></asp:TextBox>
                            <asp:Label ID="lblValidacionAct2" runat="server" Text=""></asp:Label>
                        </div>
                    </div>


                    <div id="ActualizarTelefono" runat="server" visible="false">
                        <%-- Telefono--%>
                        <div class="col-md-6" style="padding: 16px;">
                            <asp:Label ID="lblTelefonoBusqueda" runat="server" Text="Telefono: "></asp:Label>
                            <asp:TextBox ID="txtTelefonoBusqueda" class="form-control" runat="server"></asp:TextBox>
                            <asp:Label ID="lblValidacionAct3" runat="server" Text=""></asp:Label>
                        </div>
                    </div>

                    <div id="ActualizarCorreo" runat="server" visible="false">
                        <%-- Correo --%>
                        <div class="col-md-6" style="padding: 16px;">
                            <asp:Label ID="lblCorreoBusqueda" runat="server" Text="Correo: "></asp:Label>
                            <asp:TextBox ID="txtCorreoBusqueda" class="form-control" runat="server"></asp:TextBox>
                            <asp:Label ID="lblValidacionAct4" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <div id="ActualizarEdad" runat="server" visible="false">
                        <%-- Edad --%>
                        <div class="col-md-6" style="padding: 16px;">
                            <asp:Label ID="lblEdad" runat="server" Text="Edad: "></asp:Label>
                            <asp:TextBox ID="txtEdadBusqueda" class="form-control" runat="server"></asp:TextBox>
                            <asp:Label ID="lblValidacionAct5" runat="server" Text=""></asp:Label>
                        </div>
                    </div>

                    <div id="ActualizarDepartemento" runat="server" visible="false">

                        <asp:Label ID="lblDepartamento" runat="server" Text="Departamento "></asp:Label>
                        <asp:DropDownList ID="DDLdepartamento" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="DDLdepartamento_SelectedIndexChanged"></asp:DropDownList>

                    </div>

                    <div id="ActualizarMunicipios" runat="server" visible="false">

                        <asp:Label ID="lblMunicipios" runat="server" Text="Municipio "></asp:Label>
                        <asp:DropDownList ID="DDLmunicipios" AutoPostBack="true" class="form-control" runat="server"></asp:DropDownList>

                    </div>
                </div>



                <div id="BotonActualizar" runat="server" visible="false">
                    <br />
                    <asp:Button ID="btnActualizar" runat="server" class="btn btn-primary" Text="Actualizar" OnClick="btnActualizar_Click" />
                    <asp:Button ID="btnBorrarDatos" runat="server" class="btn btn-primary" Text="Borrar" OnClick="BorrarDatos_Click" />

                </div>
            </div>

        </form>



    </body>
</asp:Content>
