<%@ Page Title="" Language="C#" MasterPageFile="~/DatabaseMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DatabaseFirstApp.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-horizontal">
        <h4>Registration</h4>
        <hr />
        <div class="form-group">
            <label class="control-label col-md-2">Full Name</label>
            <div class="col-md-4">
                <asp:TextBox class="form-control" placeholder="James" runat="server" ID="txtRegFullname"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label class="control-label col-md-2">Surname</label>
            <div class="col-md-4">
                <asp:TextBox class="form-control" placeholder="Motsamai" runat="server" ID="txtRegSurname"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label class="control-label col-md-2">Username</label>
            <div class="col-md-4">
                <asp:TextBox class="form-control" placeholder="" runat="server" ID="txtRegUsername"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label class="control-label col-md-2">User Type</label>

            <div class="btn-group col-md-4">
                 &nbsp; &nbsp;<input type="radio" id="radClient" runat="server" name="user_type" value="Client">
                <label for="html">Client</label><br>
                 &nbsp;<input type="radio" id="radDriver" runat="server" name="user_type" value="Driver">
                <label for="css">Driver</label><br>
            </div>

        </div>

        <div class="form-group">
            <label class="control-label col-md-2">Password</label>
            <div class="col-md-4">
                <asp:TextBox class="form-control" placeholder="" runat="server" ID="txtRegPassword"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label class="control-label col-md-2">Confirm Password</label>
            <div class="col-md-4">
                <asp:TextBox class="form-control" placeholder="" runat="server" ID="txtRegConPassword"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button class="btn btn-default" ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
            </div>
        </div>

        <div class="text-danger" runat="server" id="report"></div>
    </div>


</asp:Content>
