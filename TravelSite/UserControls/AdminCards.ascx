<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminCards.ascx.cs" Inherits="TravelSite.UserControls.AdminCards" %>
<div class="col" style="text-align: center; margin-left: 10px;">
    <div class="card shadow-lg p-3 mb-5 bg-white rounded" style="width: 15rem;">
        <img src="<%#Eval("Pic") %>" class="card-img-top" alt="...">
        <div class="card-body" style="padding-top: 10px;">
            <h5 class="card-title">
                <%#Eval("Id") %>
            </h5>
        </div>
    </div>
</div>