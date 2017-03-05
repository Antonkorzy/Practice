﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="PraktikaE.aspx.cs" Inherits="IIS.MyApp.ПрактикаE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.EditFormHeaderCssClass %>">Практика</h2>
        <div class="<%= Constants.FormToolbarCssClass %> <%= Constants.EditFormToolbarCssClass %> <%= Constants.StickyCssClass %>">
            <asp:ImageButton ID="SaveBtn" runat="server" SkinID="SaveBtn" OnClick="SaveBtn_Click" AlternateText="<%$ Resources: Resource, Save %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="SaveAndCloseBtn" runat="server" SkinID="SaveAndCloseBtn" OnClick="SaveAndCloseBtn_Click" AlternateText="<%$ Resources: Resource, Save_Close %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="CancelBtn" runat="server" SkinID="CancelBtn" OnClick="CancelBtn_Click" AlternateText="<%$ Resources: Resource, Cancel %>" />
        </div>
        <div class="<%= Constants.FormControlsCssClass %> <%= Constants.EditFormControlsCssClass %>">
            <%-- Autogenerated section start [Controls] --%>
<!-- autogenerated start -->
<div>
	<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlИнформацияLabel" runat="server" Text="Информация" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlИнформация" runat="server">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlДатаНачалаLabel" runat="server" Text="Дата начала" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlДатаНачала" runat="server"/>
</div>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlДатаКонцаLabel" runat="server" Text="Дата конца" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlДатаКонца" runat="server"/>
</div>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlСостояниеLabel" runat="server" Text="Состояние" EnableViewState="False">
</asp:Label>
<asp:DropDownList ID="ctrlСостояние" CssClass="descTxt" runat="server">
	<asp:ListItem>ЗаявкаПодтверждена</asp:ListItem>
<asp:ListItem>Впроцессе</asp:ListItem>
<asp:ListItem>Завершена</asp:ListItem>

</asp:DropDownList>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlЗаявкаНаПрактикуLabel" runat="server" Text="Заявка на практику" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlЗаявкаНаПрактику" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlЗаявкаНаПрактикуValidator" runat="server" ControlToValidate="ctrlЗаявкаНаПрактику"
ErrorMessage="Не указано: ЗаявкаНаПрактику" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlЗаявкаНаПрактику_ИнформацияLabel" runat="server" Text="Информация" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlЗаявкаНаПрактику_Информация" runat="server" ReadOnly="true">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlКомпанияLabel" runat="server" Text="Компания" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlКомпания" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlКомпания_НазваниеLabel" runat="server" Text="Название" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlКомпания_Название" runat="server" ReadOnly="true">
</asp:TextBox>

</div>
<br/>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
