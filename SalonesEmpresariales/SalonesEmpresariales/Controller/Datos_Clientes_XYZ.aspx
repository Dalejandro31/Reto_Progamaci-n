<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPage.Master" AutoEventWireup="true" CodeBehind="Datos_Clientes_XYZ.aspx.cs" Inherits="SalonesEmpresariales.Controller.Datos_Clientes_XYZ" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .abs-center {
            display: flex;
            align-items: center;
            justify-content: center;
            min-height: 100vh;
        }

        .form {
            width: 450px;
        }

        .flex-container {
            display: flex;
            align-items: stretch;
            flex-wrap: wrap;
        }
    </style>

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

                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Identificacion: "></asp:Label>
                        <asp:TextBox ID="txt_identificacion" class="form-control" runat="server" placeholder="Cedula"></asp:TextBox>
                        <asp:Label ID="lblValidacionID" runat="server" Text=""></asp:Label>

                    </div>

                    <%-- NOMBRES --%>
                    <div class="col-md-6" style="padding:  16px;">
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Nombre "></asp:Label>
                        <asp:TextBox ID="txt_nombre" class="form-control" runat="server" placeholder="Nombres"></asp:TextBox>
                        <asp:Label ID="lblValidacionNombre" runat="server" Text=""></asp:Label>
                    </div>

                    <%-- APELLIDOS --%>
                    <div class="col-md-6" style="padding: 16px;">
                        <asp:Label ID="Label3" runat="server" Text="Apellido "></asp:Label>
                        <asp:TextBox ID="txt_apellido" class="form-control" runat="server" placeholder="Apellidos"></asp:TextBox>
                        <asp:Label ID="lblValidacionApellido" runat="server" Text=""></asp:Label>
                    </div>


                    <%-- TELEFONO --%>
                    <div class="col-md-6" style="padding: 16px;">
                        <asp:Label ID="Label4" runat="server" Text="Telefono "></asp:Label>
                        <asp:TextBox ID="txt_telefono" class="form-control" runat="server" placeholder="Telefono"></asp:TextBox>
                        <asp:Label ID="lblValidacionTelofono" runat="server" Text=""></asp:Label>
                    </div>


                    <%-- CORREO --%>
                    <div class="col-md-6" style="padding: 16px;">
                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Correo "></asp:Label>
                            <asp:TextBox ID="txt_correo" class="form-control" runat="server" placeholder="Correo"></asp:TextBox>
                            <asp:Label ID="lblValidacionCorreo" runat="server" Text=""></asp:Label>
                        </div>
                    </div>

                    <%-- EDAD --%>
                    <div class="col-md-6" style="padding: 16px;">
                        <asp:Label ID="Label6" runat="server" Text="Edad "></asp:Label><br />
                        <asp:TextBox ID="txt_edad" class="form-control" runat="server" placeholder="Edad"></asp:TextBox>
                        <asp:Label ID="lblValidacionEdad" runat="server" Text=""></asp:Label>
                    </div>


                    <%-- DEPARTAMENTO --%>
                    <div class="col-md-6" style="padding: 16px;">
                        <asp:Label ID="Label7" runat="server" Text="Departamento"></asp:Label><br />
                        <asp:DropDownList ID="DDLdepartamento" Style="width: 200px; height: 50px" class="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DDLdepartamento_SelectedIndexChanged"></asp:DropDownList>
                    </div>


                    <%-- MUNICIPIO --%>
                    <div class="col-md-6" style="padding: 16px;">

                        <asp:Label ID="Label8" runat="server" Text="Municipio "></asp:Label><br />
                        <asp:DropDownList ID="DDLmunicipios" Style="width: 200px; height: 50px" class="form-control" runat="server"></asp:DropDownList>
                    </div>


                    <div>
                        <br />
                        <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Crear" OnClick="btn_Crear_Click" />

                    </div>
                </div>
                <div class="card-footer text-muted">
                    2 days ago
                </div>
            </div>
        </form>



    </body>
</asp:Content>
