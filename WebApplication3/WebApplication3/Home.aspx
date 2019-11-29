<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication3.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="navbar">

  <a class="not" href="#home">Sale</a>
  <div class="dropdown">
    <button class="dropbtn">Nutrition </button>
    <div class="dropdown-content">
    <div class="row">
      <div class="column">  
      <a href="#">Link 1</a>
      <a href="#">Link 2</a>
      <a href="#">Link 3</a>
    </div>
    <div class="column">  
      <a href="#">Link 1</a>
      <a href="#">Link 2</a>
      <a href="#">Link 3</a>
    </div>
      <div class="column">  
      <a href="#">Link 1</a>
      <a href="#">Link 2</a>
      <a href="#">Link 3</a>
       
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
