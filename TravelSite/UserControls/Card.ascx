<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Card.ascx.cs" Inherits="TravelSite.UserControls.Card" %>
<div class="col" style="text-align: center; margin-left: 50px;">
    <div class="card shadow-lg p-3 mb-5 bg-white rounded" style="width: 15rem;">
        <img src="Images/patron.jpg" class="card-img-top" alt="...">
        <div class="card-body" style="padding-top: 10px;">
            <h5 class="card-title">
                <%#Eval("Title") %>
            </h5>
            <p class="card-text">
                <%#Eval("Text") %>
            </p>
            <a href="#" class="btn btn-outline-dark">
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-music-note-list" viewBox="0 0 16 16">
                    <path d="M12 13c0 1.105-1.12 2-2.5 2S7 14.105 7 13s1.12-2 2.5-2 2.5.895 2.5 2z"/>
                    <path fill-rule="evenodd" d="M12 3v10h-1V3h1z"/>
                    <path d="M11 2.82a1 1 0 0 1 .804-.98l3-.6A1 1 0 0 1 16 2.22V4l-5 1V2.82z"/>
                    <path fill-rule="evenodd" d="M0 11.5a.5.5 0 0 1 .5-.5H4a.5.5 0 0 1 0 1H.5a.5.5 0 0 1-.5-.5zm0-4A.5.5 0 0 1 .5 7H8a.5.5 0 0 1 0 1H.5a.5.5 0 0 1-.5-.5zm0-4A.5.5 0 0 1 .5 3H8a.5.5 0 0 1 0 1H.5a.5.5 0 0 1-.5-.5z"/>
                </svg>
            </a>
        </div>
    </div>
</div>