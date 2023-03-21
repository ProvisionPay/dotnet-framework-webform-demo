<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="dotnet.demo.webform.Enrollment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<br />
<br />
<asp:Button  runat="server" ID="EnrollUser" Text="EnrollUser" OnClick="EnrollUser_Click"/>
<asp:Button  runat="server" ID="EnrollUserWithTerminal"  Text="EnrollUserWithTerminal" OnClick="EnrollUserWithTerminal_Click"  />
<asp:Button  runat="server" ID="CancelUserEnrollment"  Text="CancelUserEnrollment" OnClick="CancelUserEnrollment_Click"  />
<asp:Button  runat="server" ID="CancelUserActivationRequest"  Text="CancelUserActivationRequest" OnClick="CancelUserActivationRequest_Click"  />
<br />
<br />
<asp:Label ID="ResultText" runat="server" />
</asp:Content>
