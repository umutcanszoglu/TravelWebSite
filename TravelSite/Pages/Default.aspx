<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainWhite.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TravelSite.Pages.Default" %>

<%@ Register Src="~/UserControls/Card.ascx" TagPrefix="uc1" TagName="Card" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ListView ID="VideosList" runat="server">
        <ItemTemplate>
            <div class="embed-responsive embed-responsive-16by9 rounded text-center" style="margin: auto;  width: 1000px; height: 550px;">
                <iframe class="embed-responsive-item" src="<%#Eval("Url") %>" allowfullscreen=0></iframe>
            </div>
        </ItemTemplate>
    </asp:ListView>
    <br />
    <br />
    <div class="row">
        <asp:ListView ID="PicturesList" runat="server">
            <ItemTemplate>
                <uc1:Card runat="server" ID="Card" />
            </ItemTemplate>
        </asp:ListView>
    </div>
   
</asp:Content>
