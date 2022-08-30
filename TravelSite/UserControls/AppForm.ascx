<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AppForm.ascx.cs" Inherits="TravelSite.UserControls.AppForm" %>
<div class="card shadow p-3 mb-5 bg-white rounded" style="width: 20rem;">
    <div class="card-body">
        <h5 class="card-title"><%#Eval("Email")%></h5>
        <h6 class="card-subtitle mb-2 text-muted"><%#Eval("Name") %> <%#Eval("Surname") %></h6>
        <p class="card-text"><%#Eval("Message") %></p>
    </div>
</div>