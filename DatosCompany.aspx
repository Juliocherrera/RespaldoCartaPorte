<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DatosCompany.aspx.cs" Inherits="DatosCompany" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main style="height: 100%; width: 100%;">
        <div class="container-fluid px-2">
            <!-- Async script executes immediately and must be after any DOM elements used in callback. -->

            <div class="row">
                <div class="col-md-12">

                    <div class="card-header">
                        <i class="fas fa-table me-1"></i>
                        Tabla
                    </div>
                    <div class="card-body">
                        <table id='tabledata' class="table table-responsive table-hover">
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>Dirección1</th>
                                    <th>Dirección2</th>
                                    <th>Dirección3</th>
                                    <th>Codigo postal</th>
                                    <th>Ciudad</th>
                                    <th>Latitud</th>
                                    <th>Longitud</th>
                                </tr>
                            </thead>
                          <%--  <tfoot>
                                <tr>
                                    <th>ID</th>
                                    <th>Dirección1</th>
                                    <th>Dirección2</th>
                                    <th>Dirección3</th>
                                    <th>Codigo postal</th>
                                    <th>Ciudad</th>
                                    <th>Latitud</th>
                                    <th>Longitud</th>
                                </tr>
                            </tfoot>
                            <tbody id="datatable1">
                            </tbody>--%>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.3.1.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/responsive/2.2.3/js/dataTables.responsive.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/responsive/2.2.3/js/responsive.bootstrap4.min.js"></script>
   
</asp:Content>

