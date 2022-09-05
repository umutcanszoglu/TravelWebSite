<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainWhite.Master" AutoEventWireup="true" CodeBehind="DiceGame.aspx.cs" Inherits="TravelSite.Pages.DiceGame"%>

<%@ Register Src="~/UserControls/Dice.ascx" TagPrefix="uc1" TagName="Dice" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="row" style="margin-left: 100px;">
                <asp:ListView ID="DiceView" runat="server">
                    <ItemTemplate>
                        <uc1:Dice runat="server" id="Dice" />
                    </ItemTemplate>
                </asp:ListView>
                <div class="col" style="margin-left:20px;">
                    <div class="row">
                        <asp:Button ID="btnRoll" class="btn btn-outline-warning" runat="server" Text="Roll" OnClick="btnRoll_OnClick"/>
                    </div>
                </div>
                <div style="margin-left: 8px;margin-top: 40px;">
                    <asp:Button ID="btnUp1" class="btn btn-outline-primary" style="margin-left: 40px;" runat="server" Text="Upgrade" OnClick="btnUp1_OnClick" />
                    <asp:Button ID="btnUp2" class="btn btn-outline-primary" style="margin-left: 65px;" runat="server" Text="Upgrade" OnClick="btnUp2_OnClick" />
                    <asp:Button ID="btnUp3" class="btn btn-outline-primary" style="margin-left: 80px;" runat="server" Text="Upgrade" OnClick="btnUp3_OnClick" />
                    <asp:Button ID="btnUp4" class="btn btn-outline-primary" style="margin-left: 75px;" runat="server" Text="Upgrade" OnClick="btnUp4_OnClick" />
                    <asp:Button ID="btnUp5" class="btn btn-outline-primary" style="margin-left: 65px;" runat="server" Text="Upgrade" OnClick="btnUp5_OnClick" />
                </div>
            </div>
        </ContentTemplate>
        <Triggers></Triggers>
    </asp:UpdatePanel>
</asp:Content>
