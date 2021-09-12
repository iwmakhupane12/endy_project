<%@ Page Title="" Language="C#" MasterPageFile="~/DatabaseMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DatabaseFirstApp.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-horizontal">
        <h4>Login</h4>
        <hr />
        <div class="form-group">
            <label class = "control-label col-md-2">Username</label>
        <div class="col-md-4">
            <asp:TextBox class="form-control" placeholder="" runat="server" id="txtLoginUsername"></asp:TextBox>
        </div>
        </div>

        <div class="form-group">
            <label class = "control-label col-md-2">Password</label>
        <div class="col-md-4">
            <asp:TextBox class="form-control" placeholder="" runat="server" id="txtLoginPassword"></asp:TextBox>
        </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                 <asp:Button class="btn btn-default" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </div>
        </div>
    </div>
</asp:Content>
