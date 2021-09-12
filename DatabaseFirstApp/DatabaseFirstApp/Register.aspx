<%@ Page Title="" Language="C#" MasterPageFile="~/DatabaseMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DatabaseFirstApp.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-horizontal">
    <h4>Registration</h4>
    <hr />
    <div class="form-group">
        <label class = "control-label col-md-2">Full Name</label>
        <div class="col-md-4">
            <asp:TextBox class="form-control" placeholder="James" runat="server" id="txtRegFullname"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label class = "control-label col-md-2">Surname</label>
        <div class="col-md-4">
            <asp:TextBox class="form-control" placeholder="Motsamai" runat="server" id="txtRegSurname"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label class = "control-label col-md-2">Username</label>
        <div class="col-md-4">
            <asp:TextBox class="form-control" placeholder="" runat="server" id="txtRegUsername"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label class = "control-label col-md-2">Password</label>
        <div class="col-md-4">
            <asp:TextBox class="form-control" placeholder="" runat="server" id="txtRegPassword"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label class = "control-label col-md-2">Confirm Password</label>
        <div class="col-md-4">
            <asp:TextBox class="form-control" placeholder="" runat="server" id="txtRegConPassword"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <asp:Button class="btn btn-default" ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
        </div>
    </div>

    <div class="text-danger" runat="server" id ="report"></div>
</div>
</asp:Content>
