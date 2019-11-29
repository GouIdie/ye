<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication3.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="navbar">
  <a class="not" href="#home">Sale</a>
  <div class="dropdown">
    <button class="dropbtn">Nutrition</button>
    <div class="dropdown-content">
    <div class="row">
      <div class="column">
      <h2>Foods</h2>
      <a href="#">Bars</a>
      <a href="#">Baking ingredients</a>
      <a href="#">Breakfast</a>
      <a href="#">Beef</a>
    </div>
    <div class="column">
      <a href="#">Dried fruits</a>
      <a href="#">Drinks</a>
      <a href="#">Fish</a>
      <a href="#">Pork</a>
      <a href="#">Snacks</a>
    </div>
      <div class="column"> 
      <h2>Nut Butters</h2>
      <a href="#">Peanut Butter</a>
      <a href="#">Almond Butter</a>
      <a href="#">Hazelnut Butter</a>
      <a href="#">Pistachio Butter</a>  
    </div>
      <div class="column"> 
      <h2>Trending</h2> 
      <a href="#">Peanut Butter 1KG</a>   
      <a href="#">Protein Snack Bars x12</a>     
      <a href="#">Oats 1KG</a>
      <a href="#">High Protein Bagels</a>     
      </div>
    </div>
    </div>
</div>
  <div class="dropdown">
    <button class="dropbtn">Supplements</button>
    <div class="dropdown-content">
      <a href="#">Link 1</a>
      <a href="#">Link 2</a>
      <a href="#">Link 3</a>
    </div>
  </div>
  <a class="not" href="#news">News</a>
</div>




</asp:Content>
