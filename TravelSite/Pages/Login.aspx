<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TravelSite.Pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br />
            <form>
                <div class="form-group" style="margin-left: 100px; margin-right: 100px;">
                    <label for="exampleInputEmail1">Email</label>
                    <asp:TextBox ID="txtEmail" class="form-control shadow-sm p-3 mb-5 bg-white rounded" runat="server"></asp:TextBox>
                </div>
                <br />
                <div class="form-group" style="margin-left: 100px; margin-right: 100px;">
                    <label for="exampleInputPassword1">Şifre</label>
                    <asp:TextBox ID="txtPassword" class="form-control shadow-sm p-3 mb-5 bg-white rounded" type="password" runat="server"></asp:TextBox>
                </div>

                <asp:Button ID="btnLogin" class="btn btn-outline-warning" type="password" style="margin-left: 100px; margin-right: 100px;" runat="server" Text="Giriş Yap" OnClick="btnLogin_OnClick" />
            </form>
        </ContentTemplate>
        <Triggers></Triggers>
    </asp:UpdatePanel>
</asp:Content>
