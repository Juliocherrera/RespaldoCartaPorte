<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main style="height: 100%; width: 100%;">
        <div class="container-fluid px-2">
            <h4 class="mt-4">Actualizar</h4>
            <div class="row">
                <div class="col-md-2">
                    <input class="form-control" id="inputcmp" type="text" placeholder="Compañia" />
                </div>
                <div class="col-md-2">
                    <input class="form-control" id="inputdir1" type="text" placeholder="Dirreción1" />
                </div>
                <div class="col-md-2">
                    <input class="form-control" id="inputdir2" type="text" placeholder="Dirreción2" />
                </div>
                <div class="col-md-2">
                    <input class="form-control" id="inputdir3" type="text" placeholder="Dirreción3" />
                </div>
                <div class="col-md-2">
                    <input class="form-control" id="inputcp" type="text" placeholder="CP" />
                </div>
                <div class="col-md-2">
                    <input class="form-control" id="inputciudad" type="text" placeholder="Ciudad" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-2">
                    <input class="form-control" id="inputlat" type="text" placeholder="Latitud" />
                </div>
                <div class="col-md-2">
                    <input class="form-control" id="inputlng" type="text" placeholder="Longitud" />
                </div>
                <div class="col-md-2">
                    <button class="btn btn-primary" type="button" onclick="javascript:updtlatlngjs();">Actualizar</button>
                </div>
                <div class="col-md-2">
                    <button class="btn btn-danger" type="button" onclick="javascript:borrar();">Cancelar</button>
                </div>
            </div>

            <!-- Async script executes immediately and must be after any DOM elements used in callback. -->

            <div class="row">
                <div class="col-md-12">
                    <div class="card-header">
                        <i class="fas fa-table me-1"></i>
                        Datos de ubicación
                    </div>
                    <div class="card-body">
                        <div id='tabledata'>

                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="container-fluid px-2" id="conteiner">
            <div class="row" id="rowwe">
                <%--    <div id="floating-panel">
                    <input id="address" type="text" value="Sydney, NSW" />
                    <input id="submit" type="button" value="Geocode" />
                </div>--%>
                <div id="container">
                    <div id="map"></div>
                    <div id="overview"></div>
                </div>
            </div>
        </div>

    </main>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <script src="js/jsmapa.js"></script>
</asp:Content>
