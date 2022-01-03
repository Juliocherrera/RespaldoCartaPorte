<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="layoutAuthentication">
        <div id="layoutAuthentication_content">
            <main>
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-lg-5">
                            <div class="card shadow-lg border-0 rounded-lg mt-5">
                                <div class="card-header">
                                    <h3 class="text-center font-weight-light my-4">¡Bienvenido!</h3>
                                </div>
                                <div class="card-body">

                                    <div class="form-floating mb-3">
                                        <input class="form-control" id="inputEmail" type="email" placeholder="Ejemplo admin@mail.com">
                                        <label for="inputEmail">Correo</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <input class="form-control" id="inputPassword" type="password" placeholder="Contraseña">
                                        <label for="inputPassword">Contraseña</label>
                                    </div>
                                    <%--<div class="form-check mb-3">
                                            <input class="form-check-input" id="inputRememberPassword" type="checkbox" value="">
                                            <label class="form-check-label" for="inputRememberPassword">Remember Password</label>
                                        </div>--%>
                                    <div class="d-flex align-items-center justify-content-between mt-4 mb-0">
                                        <a class="small" data-toggle="modal" data-target="#myModal" href="#">Recuperar contraseña</a>
                                        <button id="btnlogusu" class="btn btn-primary">Entrar</button>
                                    </div>

                                </div>
                               <%-- <div class="card-footer text-center py-3">
                                    <div class="small"><a href="#">Need an account? Sign up!</a></div>
                                </div>--%>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
        </div>

        <div id="layoutAuthentication_footer">
            <footer class="py-4 bg-light mt-auto">
                <div class="container-fluid px-4">
                    <div class="d-flex align-items-center justify-content-between small">
                        <div class="text-muted">Copyright © Your Website 2021</div>
                        <div>
                            <a href="#">Privacy Policy</a>
                            <a href="#">Terms &amp; Conditions</a>
                        </div>
                    </div>
                </div>
            </footer>
        </div>
    </div>


    <div class="modal" tabindex="-1" role="dialog">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Modal title</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <p>Modal body text goes here.</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary">Save changes</button>
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>

    <!-- The Modal -->
    <div class="modal" id="myModal">
        <div class="modal-dialog">
            <div class="modal-content">
                <!-- Modal Header -->
                <div class="modal-header">
                    <h4 class="modal-title">Recuperar contraseña</h4>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <!-- Modal body -->
                <div class="modal-body">
                    <div class="card-body">
                        <form>
                            <div class="form-floating mb-3">
                                <input class="form-control" id="inputPassword2" type="password" placeholder="Contraseña">
                                <label for="inputPassword2">Contraseña</label>
                            </div>
                            <div class="form-floating mb-3">
                                <input class="form-control" id="inputPassword1" type="password" placeholder="Contraseña">
                                <label for="inputPassword1">Repetir contraseña</label>
                            </div>
                        </form>
                    </div>
                </div>
                <!-- Modal footer -->
                <div class="modal-footer">
                    <button id="btnupdpass" type="button" class="btn btn-success" data-dismiss="modal">Actualizar</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <script src="js/jslogin.js"></script>
    <script src="//cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</asp:Content>

