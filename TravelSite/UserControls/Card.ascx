<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Card.ascx.cs" Inherits="TravelSite.UserControls.Card" %>

<div class="col" style="text-align: center; margin-left: 50px;">
    <div class="card shadow-lg p-3 mb-5 bg-white rounded" style="width: 15rem;">
        <img src="<%#Eval("Pic") %>" class="card-img-top" alt="...">
        <div class="card-body" style="padding-top: 10px;">
            <h5 class="card-title">
                <%#Eval("Title") %>
            </h5>
            <p class="card-text">
                <%#Eval("Text") %>
            </p>
        </div>
    </div>
</div>
