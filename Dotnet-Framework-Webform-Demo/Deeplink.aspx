<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Deeplink.aspx.cs" Inherits="dotnet.demo.webform.Deeplink" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <asp:Button  runat="server" ID="CreatePaymentSessionToken" Text="CreatePaymentSessionToken" OnClick="CreatePaymentSessionToken_Click"/>
    <asp:Button  runat="server" ID="GetPaymentSessionStatus" Text="GetPaymentSessionStatus" OnClick="GetPaymentSessionStatus_Click"/>
    <asp:Button  runat="server" ID="GetTransactionByPaymentSessionToken" Text="GetTransactionByPaymentSessionToken" OnClick="GetTransactionByPaymentSessionToken_Click"/>
<br />
<br />
    <asp:Label ID="ResultText" runat="server" />
</asp:Content>
