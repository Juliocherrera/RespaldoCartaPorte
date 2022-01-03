<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TblErrores.aspx.cs" Inherits="TblErrores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main style="height: 100%; width: 100%;">
        <div class="container-fluid px-2">
            <!-- Async script executes immediately and must be after any DOM elements used in callback. -->

            <div class="row">
                <div class="col-md-12">

                    <div class="card-header">
                        <i class="fas fa-table me-1"></i>
                        Historial de Errores
                    </div>
                    <div class="table-responsive">
                        <table id='tabledatacp' class="table table-responsive table-hover">
                            <thead>
                                <tr>
                                    <th>Fecha</th>
                                    <th>Folio</th>
                                    <th>Error1</th>
                                    <th>Error2</th>
                                    <th>Error3</th>
                                    <th>Error4</th>
                                    <th>Error5</th>
                                    <th>Error6</th>
                                    <th>Error7</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <script src="js/jstblErrores.js"></script>
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.3.1.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js"></script>
    <%--    <script type="text/javascript" src="https://cdn.datatables.net/responsive/2.2.3/js/dataTables.responsive.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/responsive/2.2.3/js/responsive.bootstrap4.min.js"></script>--%>
</asp:Content>

