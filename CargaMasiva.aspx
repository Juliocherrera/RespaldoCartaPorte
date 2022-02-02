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
            <form id="form1" runat="server">
                <div class="container-fluid mt-4">
                        <div class="card">
                         <div class="card-header">
                           Cargar Archivo
                         </div>
                         <div class="card-body">
                           <div class="row">
                               
                               <div class="col-sm-12">
                                   <div class="form-row">
                                       <%--<div class="form-group col-sm-10">
                                         <label for="txtName">Numero de orden</label>
                                           <asp:TextBox ID="txtName" CssClass="form-control" runat="server" Width="140" />
                                           
                                       </div>--%>
                                       <div class="form-group col-sm-10">
                                         <label for="FileUpload1">Archivo</label>
                                           <asp:FileUpload ID="FileUpload1" CssClass="form-control-file" runat="server" required="true"/>
                                           
                                       </div>
                                       <div class="form-group col-sm-2">
                                         <asp:Button ID="Button1" runat="server" Text="Cargar" CssClass="btn btn-block btn-success mt-4" OnClick="Button1_Click" />
                                       </div>
                                   </div>
                               </div>
       
                           </div>
                             <hr />
                          <div class="row">
                              <div class="col-sm-12">
                                  <div class="card">
                                 <div class="card-header p-1">
                                   Registros Cargados
                                 </div>
                                 <div class="card-body">
                                     <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered mitabla table-hover"></asp:GridView>
                                 </div>
                               </div>
                            </div>
                              
       
                          </div>
                         </div>
                       </div>
               </div>
       
               
               <%--<div>
                   
                   <br />
                   <br />
                  
               </div>
               <br />
               <div>
                   <asp:Label ID="lblrespuesta" runat="server"></asp:Label>
               </div>--%>
               
           </form>
           
            
        </div>

        
    </main>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <script src="js/jsCartaPorte.js"></script>
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.3.1.js"></script>
    <script src="//cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js"></script>
    <%--<script type="text/javascript" src="https://cdn.datatables.net/responsive/2.2.3/js/dataTables.responsive.min.js"></script>--%>
    <%--<script type="text/javascript" src="https://cdn.datatables.net/responsive/2.2.3/js/responsive.bootstrap4.min.js"></script>--%>
</asp:Content>

