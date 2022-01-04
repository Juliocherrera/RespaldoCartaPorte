<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CartaPorte.aspx.cs" Inherits="CartaPorte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <main style="height: 100%; width: 100%;">


        <div class="container-fluid px-2">
            <div id="cargando" class="row">
                <div class="col-md-12" >
                    <div class="mx-auto" style="width: 200px;">
                        <div class="spinner-border" style="width: 5rem; height: 5rem;" role="status">
                            <span class="sr-only">Loading...</span>
                        </div>
                        <p>Procesando...</p>
                    </div>
                </div>
            </div>

           
            <div style="display:none !important" class="row">
                <div class="col-md-2">
                    <p>Compañia<input class="form-control" id="inputleg" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Tipo<input class="form-control" id="inputtipo" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Fecha<input class="form-control" id="inputfecha" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Subtotal<input class="form-control" id="inputsubtotal" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Total imp trasladado<input class="form-control" id="inputTotalimptrasl" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Total imp retenido<input class="form-control" id="inputTotalimpreten" type="text" /></p>
                </div>
            </div>
            <div style="display:none !important" class="row">
                <div class="col-md-2">
                    <p>Descuentos<input class="form-control" id="inputDescuentos" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Total<input class="form-control" id="inputTotal" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>FormaPago<input class="form-control" id="inputFormaPago" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Condipago<input class="form-control" id="inputCondipago" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Condipago<input class="form-control" id="inputMetodoPago" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Moneda<input class="form-control" id="inputMoneda" type="text" /></p>
                </div>
            </div>
            <div style="display:none !important" class="row">
                <div class="col-md-2">
                    <p>RFC<input class="form-control" id="inputRFC" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Codigo SAT<input class="form-control" id="inputCodSAT" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Id Producto<input class="form-control" id="inputIdProducto" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Producto<input class="form-control" id="inputProducto" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Clave origen<input class="form-control" id="inputOrigen" type="text" /></p>
                </div>
                <div class="col-md-2">
                    <p>Clave destino<input class="form-control" id="inputDestino" type="text" /></p>
                </div>
            </div>
        </div>

        <div class="container-fluid px-2">
            <!-- Async script executes immediately and must be after any DOM elements used in callback. -->
            <div class="row">
                <div class="col-md-12">
                    <div class="card-header">
                        <i class="fas fa-table me-1"></i>
                        Cartas Porte Generadas:
                    </div>
                    <div class="table-responsive mt-3">
                        <table id='tabledataCPD' class="table display" >
                            <thead>
                                <tr>
                                    <th>Folio</th>
                                    <th>Serie</th>
                                    <th>UUID</th>
                                    <th>ZIP</th>
                                    <th>PDF</th>
                                    <th>XML</th>
                                    <th>Cancelar</th>
                                    <th>Segmento</th>
                                    <th>Fecha</th>
                                    <th>Total</th>
                                    <th>Moneda</th>
                                    <th>RFC</th>
                                    <th style="display:none !important">Origen</th>
                                    <th style="display:none !important">Destino</th>
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
    <script src="js/jsCartaPorte.js"></script>
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.5.1.js"></script>
   
    <script src="https://cdn.datatables.net/1.11.3/js/jquery.dataTables.min.js"></script>
    
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</asp:Content>

