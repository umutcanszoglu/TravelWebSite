<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainWhite.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="TravelSite.Pages.Admin" %>

<%@ Register Src="~/UserControls/AdminCards.ascx" TagPrefix="uc1" TagName="AdminCards" %>
<%@ Register Src="~/UserControls/AppForm.ascx" TagPrefix="uc1" TagName="AppForm" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="margin-left: 50px; margin-top: 5px;">Resim Yükleme</h1>
    <hr class="my-4" style="margin-left: 50px; margin-right: 50px;">
    <div class="form-group" style="margin-left: 50px; margin-right: 50px; margin-top: 5px;">
        <label for="exampleInputEmail1">Resim Başlığı:</label>
        <asp:TextBox ID="txtTitle" class="form-control shadow-sm p-3 mb-5 bg-white rounded" runat="server"></asp:TextBox>
        <label for="exampleInputPassword1">Resim Açıklaması:</label>
        <asp:TextBox ID="txtText" class="form-control shadow-sm p-3 mb-5 bg-white rounded" runat="server"></asp:TextBox>        
        <asp:FileUpload ID="ImageUpload" runat="server" />

        <br />
        <br />

        <asp:Button ID="btnAdd" class="btn btn-outline-warning"  runat="server" Text="Yükle" OnClick="btnAdd_OnClick" />    

    </div>

    <br />

    <h1 style="margin-left: 50px; margin-top: 5px;">Resim Silme</h1>
    <hr class="my-4" style="margin-left: 50px; margin-right: 50px;">
    <div class="form-group" style="margin-left: 50px; margin-right: 50px; margin-top: 5px;">
        <div class="row">
            <asp:ListView ID="ImageList" runat="server">
                <ItemTemplate>
                    <uc1:AdminCards runat="server" id="AdminCards" />
                </ItemTemplate>
            </asp:ListView>
        </div>
        <br />
        <label for="exampleInputPassword1">Resmin Altındaki Sayıyı Giriniz:</label>
        <asp:TextBox ID="txtDel" class="form-control shadow-sm p-3 mb-5 bg-white rounded" runat="server"></asp:TextBox>
        <br />

        <asp:Button ID="btnDel" class="btn btn-outline-warning" runat="server" Text="Sil" OnClick="btnDel_OnClick" />
        <asp:Button ID="btnShow" class="btn btn-outline-warning" runat="server" Text="Resimleri Göster" OnClick="btnShow_OnClick" />


    </div>
    
    <br />
    
    <h1 style="margin-left: 50px; margin-top: 5px;">Video Güncelleme</h1>
    <hr class="my-4" style="margin-left: 50px; margin-right: 50px;">
    <div class="form-group" style="margin-left: 50px; margin-right: 50px; margin-top: 5px;">
        
        <label for="exampleInputEmail1">Video Url:</label>
        <asp:TextBox ID="txtUrl" class="form-control shadow-sm p-3 mb-5 bg-white rounded" runat="server"></asp:TextBox>
        <asp:Button ID="btnVideo" class="btn btn-outline-warning" runat="server" Text="Güncelle" OnClick="btnVideo_OnClick" />
    </div>
    <br />
    
    <h1 style="margin-left: 50px; margin-top: 5px;">Başvuru Formları</h1>
    <hr class="my-4" style="margin-left: 50px; margin-right: 50px;">
    <div class="row" style="margin-left: 50px; margin-right: 50px; margin-top: 5px;">
        <asp:ListView ID="ListView1" runat="server">
            <ItemTemplate>
                <uc1:AppForm runat="server" id="AppForm" />
            </ItemTemplate>
        </asp:ListView>
    </div>
    <br />
    <asp:Button ID="btnFormShow" class="btn btn-outline-warning" style="margin-left: 50px;" runat="server" Text="Göster" OnClick="btnFormShow_Click" />

    

</asp:Content>
