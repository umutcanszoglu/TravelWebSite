<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Dice.ascx.cs" Inherits="TravelSite.UserControls.Dice" %>
<div class="card text-center shadow p-3 mb-5 bg-white rounded" style="width: 9rem; margin-left: 20px;">
    <div class="card-body">
        <h5 class="card-title" style="font-size: 50px;"><%#Eval("DiceString") %></h5>
        <p class="card-text">Level: <%#Eval("Level") %></p>
        <p class="card-text">X: <%#Eval("Multipy") %></p>
        <p class="card-text">Score: <%#Eval("Score") %></p>
    </div>
</div>