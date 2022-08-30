<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserCard.ascx.cs" Inherits="TravelSite.UserControls.UserCard" %>
<div class="card" style="width: 18rem;">
    <div class="card-body">
        <h5 class="card-title">Card title</h5>
        <h6 class="card-subtitle mb-2 text-muted">Card subtitle</h6>
        <p class="card-text"><%#Eval("Email") %></p>
        
    </div>
</div>