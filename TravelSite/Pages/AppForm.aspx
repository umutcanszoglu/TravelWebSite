<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainWhite.Master" AutoEventWireup="true" CodeBehind="AppForm.aspx.cs" Inherits="TravelSite.Pages.AppForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form>
        <h1 style="margin-left: 100px; margin-top: 5px;">Başvuru Yap</h1>
        <hr class="my-4" style="margin-left: 100px; margin-right: 100px;">
        <div class="form-group" style="margin-left: 100px; margin-right: 100px;">
            <label for="exampleFormControlInput1">Ad</label>
            <asp:TextBox ID="txtName" class="form-control" runat="server"></asp:TextBox>
        </div>

        <div class="form-group" style="margin-left: 100px; margin-right: 100px;">
            <label for="exampleFormControlInput1">Soyad</label>
            <asp:TextBox ID="txtSurname" class="form-control" runat="server"></asp:TextBox>
        </div>

        <div class="form-group" style="margin-left: 100px; margin-right: 100px;">
            <label for="exampleFormControlInput1">Email</label>
            <asp:TextBox ID="txtEmail" class="form-control" type="email" runat="server" TextMode="Email"></asp:TextBox>
        </div>
        
        <div class="form-group" style="margin-left: 100px; margin-right: 100px;">
            <label for="exampleFormControlTextarea1">Mesajınız</label>
            <asp:TextBox ID="txtMessage" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
        
        <asp:Button ID="btnSend" runat="server"  class="btn btn-outline-warning" style="margin-left: 100px; margin-right: 100px;" Text="Gönder" OnClick="btnSend_OnClick" />
        

    </form>
</asp:Content>
